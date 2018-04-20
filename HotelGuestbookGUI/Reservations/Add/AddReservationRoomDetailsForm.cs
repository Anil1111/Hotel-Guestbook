using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.ExtensionMethods;

namespace HotelGuestbookGUI.Reservations.Add
{
    public partial class AddReservationRoomDetailsForm : Form
    {
        private PersonInfo Person;
        private ApartmentInfo SelectedApartment;
        private ReservationInfo Reservation;
        public IEnumerable<ApartmentInfo> AvailableApartments;


        /// <summary>
        /// Creates a new instance of AddReservationRoomDetailsForm.
        /// </summary>
        /// <param name="person">Person's data to display.</param>
        /// <param name="apartment">Apartment data to display.</param>
        /// <param name="reservation">Reservation details to display.</param>
        public AddReservationRoomDetailsForm(PersonInfo person = null, ApartmentInfo apartment = null, ReservationInfo reservation = null)
        {
            InitializeComponent();

            InitializeLabelsText(person, apartment, reservation);

            FromDateTimePicker_ValueChanged(null, null);

            UpdateNumberOfAvailableApartments();

            proceedButton.Enabled = false;

            infoLabel.Text = string.Empty;
        }


        #region Events


        private void BackButton_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDetailsForm = new AddReservationPersonalDataForm(Person);

            addReservationPersonalDetailsForm.Show();
            Close();
        }


        private void ProceedButton_Click(object sender, EventArgs e)
        {
            var addReservationReviewForm = new AddReservationReviewForm(Person, SelectedApartment, Reservation);

            addReservationReviewForm.Show();
            Close();
        }


        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDateTimePicker.Value >= toDateTimePicker.Value)
            {
                toDateTimePicker.Value = fromDateTimePicker.Value.AddDays(1);
            }

            UpdateNumberOfAvailableApartments();

            CheckApartmentAvailability();

            UpdatePriceLabel();
        }


        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (toDateTimePicker.Value <= fromDateTimePicker.Value)
            {
                fromDateTimePicker.Value = toDateTimePicker.Value.AddDays(-1);
            }

            UpdateNumberOfAvailableApartments();

            CheckApartmentAvailability();

            UpdatePriceLabel();
        }


        private void MinimalCapacityNumericUpDown_ValueChanged(object sender, EventArgs e) => UpdateNumberOfAvailableApartments();


        private void DoubleBedsNumericUpDown_ValueChanged(object sender, EventArgs e) => UpdateNumberOfAvailableApartments();
        

        private void AvailableApartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedApartment = AvailableApartments.ElementAt(availableApartmentsComboBox.SelectedIndex);

            actualRoomNumberLabel.Text = SelectedApartment.Number.ToString();

            proceedButton.Enabled = true;

            var reservation = new ReservationInfo()
            {
                From = fromDateTimePicker.Value,
                To = toDateTimePicker.Value,
                Person = Person,
                PersonId = Person.PersonId,
                Apartment = SelectedApartment,
                ApartmentId = SelectedApartment.ApartmentId
            };

            Reservation = reservation;

            CheckApartmentAvailability();
        }


        #endregion


        /// <summary>
        /// Initializes the labels' text from supplied details.
        /// </summary>
        /// <param name="person">Person's data to display.</param>
        /// <param name="apartment">Apartment data to display.</param>
        /// <param name="reservation">Reservation details to display.</param>
        private void InitializeLabelsText(PersonInfo person, ApartmentInfo apartment, ReservationInfo reservation)
        {
            if (person != null)
            {
                Person = person;

                nameLabel.Text = person.FirstName + @" " + person.LastName;
                emailLabel.Text = person.Email;
                dateOfBirthLabel.Text = person.DateOfBirth.ToShortDateString();
            }

            if (apartment != null)
            {
                minimalCapacityNumericUpDown.Value = apartment.Capacity;
                doubleBedsNumericUpDown.Value = apartment.DoubleBeds;
            }

            if (reservation != null)
            {
                fromDateTimePicker.Value = reservation.From;
                toDateTimePicker.Value = reservation.To;
            }
        }


        /// <summary>
        /// Updates the list of available apartments.
        /// </summary>
        private void UpdateNumberOfAvailableApartments()
        {
            var minimalCapacity = int.Parse(minimalCapacityNumericUpDown.Value.ToString(CultureInfo.InvariantCulture));
            var doubleBeds = int.Parse(doubleBedsNumericUpDown.Value.ToString(CultureInfo.InvariantCulture));
            var from = fromDateTimePicker.Value;
            var to = toDateTimePicker.Value;

            AvailableApartments = ApartmentProvider.GetAvailableApartments(minimalCapacity, doubleBeds, from, to);

            var availableApartmentsCount = AvailableApartments.Count();

            availableApartmentsLabel.Text = availableApartmentsCount.ToString();

            CheckApartmentsComboBoxAvailability(availableApartmentsCount);

            RefreshGui();
        }


        /// <summary>
        /// Checks if there are apartments available and if no, disables the combo box.
        /// </summary>
        /// <param name="availableApartmentsCount">Number of available apartments.</param>
        private void CheckApartmentsComboBoxAvailability(int availableApartmentsCount)
        {
            availableApartmentsComboBox.Enabled = availableApartmentsCount != 0;
        }


        /// <summary>
        /// Updates the final price label.
        /// </summary>
        private void UpdatePriceLabel()
        {
            if (SelectedApartment != null)
            {
                totalPriceLabel.Text = SelectedApartment.Price * Math.Round((toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays) + @" EUR";
            }
        }


        /// <summary>
        /// Checks if the selected apartment is available within the selected dates.
        /// </summary>
        private void CheckApartmentAvailability()
        {
            if (SelectedApartment == null)
            {
                return;
            }

            var start = fromDateTimePicker.Value.Date;
            var end = toDateTimePicker.Value.Date;

            var reservations = SelectedApartment.GetAllReservationsForApartment().ToList();

            foreach (var reservation in reservations)
            {
                if (reservation.From < start && reservation.To > start ||
                    reservation.From < end && reservation.To > end     ||
                    start <= reservation.From && end >= reservation.To)
                {
                    infoLabel.Text = @"Selected reservation dates for this room collide with another reservation."
                                     + $@"Reservation start: {reservation.From.Date:dd.MM.yyyy}, reservation end: {reservation.To.Date:dd.MM.yyyy}";

                    proceedButton.Enabled = false;

                    return;
                }

                infoLabel.Text = "";
                proceedButton.Enabled = true;
            }
        }


        /// <summary>
        /// Refreshes the UI.
        /// </summary>
        private void RefreshGui()
        {
            availableApartmentsComboBox.Items.Clear();
            foreach (var apartment in AvailableApartments)
            {
                availableApartmentsComboBox.Items.Add(apartment.ToDropDownString());
            }
        }
    }
}
