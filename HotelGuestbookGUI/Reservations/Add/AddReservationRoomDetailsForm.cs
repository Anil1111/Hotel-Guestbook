using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;

namespace HotelGuestbookGUI.Reservations.Add
{
    public partial class AddReservationRoomDetailsForm : Form
    {
        private PersonInfo _person;
        private ApartmentInfo _selectedApartment;
        private ReservationInfo _reservation;
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
        }


        #region Events


        private void BackButton_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDetailsForm = new AddReservationPersonalDataForm(_person);

            addReservationPersonalDetailsForm.Show();
            Close();
        }


        private void ProceedButton_Click(object sender, EventArgs e)
        {
            var addReservationReviewForm = new AddReservationReviewForm(_person, _selectedApartment, _reservation);

            addReservationReviewForm.Show();
            Close();
        }


        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            toDateTimePicker.Value = fromDateTimePicker.Value.AddDays(1);

            UpdateNumberOfAvailableApartments();
        }


        private void MinimalCapacityNumericUpDown_ValueChanged(object sender, EventArgs e) => UpdateNumberOfAvailableApartments();


        private void DoubleBedsNumericUpDown_ValueChanged(object sender, EventArgs e) => UpdateNumberOfAvailableApartments();


        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e) => UpdateNumberOfAvailableApartments();


        private void AvailableApartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedApartment = AvailableApartments.ElementAt(availableApartmentsComboBox.SelectedIndex);

            actualRoomNumberLabel.Text = _selectedApartment.Number.ToString();
            totalPriceLabel.Text = (_selectedApartment.Price * (toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays) + @" EUR";

            proceedButton.Enabled = true;

            var reservation = new ReservationInfo()
            {
                From = fromDateTimePicker.Value,
                To = toDateTimePicker.Value,
                Person = _person,
                PersonId = _person.PersonId,
                Apartment = _selectedApartment,
                ApartmentId = _selectedApartment.ApartmentId
            };

            _reservation = reservation;
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
                _person = person;

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
