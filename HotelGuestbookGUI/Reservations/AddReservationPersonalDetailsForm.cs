using HotelGuestbook.Classes.Person;
using HotelGuestbook.Helpers;
using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class AddReservationPersonalDataForm : Form
    {
        private PersonInfo Person;

        public AddReservationPersonalDataForm(PersonInfo person = null)
        {
            InitializeComponent();

            Person = person;

            if (Person != null)
            {
                firstNameTextBox.Text = person.FirstName;
                lastNameTextBox.Text = person.LastName;
                emailTextBox.Text = person.Email;
                dateOfBirthDateTimePicker.Value = person.DateOfBirth;
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            var person = CreatePersonFromData();

            var addReservationRoomDetailsForm = new AddReservationRoomDetailsForm(person);

            addReservationRoomDetailsForm.Show();
            Close();
        }


        /// <summary>
        /// 
        /// </summary>
        private bool ValidateData()
        {
            if (!ValidationHelper.IsValidFirstName(firstNameTextBox.Text))
            {
                MessageBox.Show("The first name must not be empty.");

                return false;
            }

            if (!ValidationHelper.IsValidLastName(lastNameTextBox.Text))
            {
                MessageBox.Show("The last name must not be empty.");

                return false;
            }

            if (!ValidationHelper.IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Email is either empty or is in incorrect format.");

                return false;
            }

            if (!ValidationHelper.IsPersonAtLeastEighteen(ConversionHelper.ConvertStringToDateTime(dateOfBirthDateTimePicker.Value.ToString("dd.MM.yyy"))))
            {
                MessageBox.Show("You must be at least 18 to make a reservation!");

                return false;
            }

            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        private PersonInfo CreatePersonFromData()
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var email = emailTextBox.Text;
            var dateOfBirth = ConversionHelper.ConvertStringToDateTime(dateOfBirthDateTimePicker.Value.ToString("dd.MM.yyy"));

            return PersonProvider.GetPersonByEmail(email) ?? new PersonInfo(firstName, lastName, email, dateOfBirth);
        }
    }
}
