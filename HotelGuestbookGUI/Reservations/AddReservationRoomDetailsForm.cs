using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
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
            toDateTimePicker.Value = fromDateTimePicker.Value.AddDays(1);

            UpdateNumberOfAvailableApartments();
        }

        private void MinimalCapacityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfAvailableApartments();
        }

        private void DoubleBedsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfAvailableApartments();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateNumberOfAvailableApartments();
        }

        
        private void AvailableApartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedApartment = AvailableApartments.ElementAt(availableApartmentsComboBox.SelectedIndex);

            actualRoomNumberLabel.Text = SelectedApartment.Number.ToString();
            totalPriceLabel.Text = (SelectedApartment.Price * (toDateTimePicker.Value - fromDateTimePicker.Value).TotalDays).ToString() + " EUR";

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

                nameLabel.Text = person.FirstName + " " + person.LastName;
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
            var minimalCapacity = Int32.Parse(minimalCapacityNumericUpDown.Value.ToString());
            var doubleBeds = Int32.Parse(doubleBedsNumericUpDown.Value.ToString());
            var from = fromDateTimePicker.Value;
            var to = toDateTimePicker.Value;

            AvailableApartments = ApartmentProvider.GetAvailableApartments(minimalCapacity, doubleBeds, from, to);

            var availableApartmentsCount = AvailableApartments.Count();

            availableApartmentsLabel.Text = availableApartmentsCount.ToString();

            CheckApartmentsComboBoxAvailability(availableApartmentsCount);

            RefreshGUI();
        }


        /// <summary>
        /// Checks if there are apartments available and if no, dislables the combo box.
        /// </summary>
        /// <param name="availableApartmentsCount">Number of available apartments.</param>
        private void CheckApartmentsComboBoxAvailability(int availableApartmentsCount)
        {
            if (availableApartmentsCount == 0)
            {
                availableApartmentsComboBox.Enabled = false;
            }
            else
            {
                availableApartmentsComboBox.Enabled = true;
            }
        }


        /// <summary>
        /// Refreshes the UI.
        /// </summary>
        private void RefreshGUI()
        {
            availableApartmentsComboBox.Items.Clear();
            foreach (var apartment in AvailableApartments)
            {
                availableApartmentsComboBox.Items.Add(apartment.ToDropDownString());
            }
        }
    }
}
