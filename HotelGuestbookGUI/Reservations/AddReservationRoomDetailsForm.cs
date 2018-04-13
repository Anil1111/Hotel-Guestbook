using HotelGuestbook.Classes.Person;
using HotelGuestbook.Helpers;
using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class AddReservationRoomDetailsForm : Form
    {
        private PersonInfo Person;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        public AddReservationRoomDetailsForm(PersonInfo person = null)
        {
            InitializeComponent();

            Person = person;

            nameLabel.Text = person.FirstName + " " + person.LastName;
            emailLabel.Text = person.Email;
            dateOfBirthLabel.Text = person.DateOfBirth.ToShortDateString();
        }


        /// <summary>
        /// 
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDetailsForm = new AddReservationPersonalDataForm(Person);

            addReservationPersonalDetailsForm.Show();
            Close();
        }


        /// <summary>
        /// 
        /// </summary>
        private void proceedButton_Click(object sender, EventArgs e)
        {
            var addReservationReviewForm = new AddReservationReviewForm();

            addReservationReviewForm.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (fromDateTimePicker.Value < DateTime.Today.AddDays(1))
            {
                MessageBox.Show("The reservation must not begin sooner than tomorrow.");

                return;
            }

            if (toDateTimePicker.Value <= fromDateTimePicker.Value)
            {
                MessageBox.Show("The end of the reservation must be later that the beginning.");

                return;
            }

            var searchApartmentForm = new SearchApartmentForm(minimalCapacityNumericUpDown.Value, doubleBedsNumericUpDown.Value, fromDateTimePicker.Value, toDateTimePicker.Value);

            searchApartmentForm.Show();
        }
    }
}
