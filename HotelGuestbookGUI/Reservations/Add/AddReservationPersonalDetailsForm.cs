using System;
using System.Windows.Forms;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Helpers;

namespace HotelGuestbookGUI.Reservations.Add
{
    public partial class AddReservationPersonalDataForm : Form
    {
        /// <summary>
        /// Creates a new instance of AddReservationPersonalDataForm.
        /// </summary>
        /// <param name="person">Person's data to display.</param>
        public AddReservationPersonalDataForm(PersonInfo person = null)
        {
            InitializeComponent();

            if (person == null)
            {
                return;
            }

            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
            emailTextBox.Text = person.Email;
            dateOfBirthDateTimePicker.Value = person.DateOfBirth;
        }


        #region Events


        private void BackButton_Click(object sender, EventArgs e) => Close();


        private void ProceedButton_Click(object sender, EventArgs e)
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


        #endregion


        /// <summary>
        /// Returns true if supplied the personal data is valid.
        /// </summary>
        private bool ValidateData()
        {
            if (!ValidationHelper.IsValidName(firstNameTextBox.Text))
            {
                MessageBox.Show(@"The first name must not be empty.");

                return false;
            }

            if (!ValidationHelper.IsValidName(lastNameTextBox.Text))
            {
                MessageBox.Show(@"The last name must not be empty.");

                return false;
            }

            if (!ValidationHelper.IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show(@"Email is either empty or is in incorrect format.");

                return false;
            }

            if (!ValidationHelper.IsPersonAtLeastEighteen(ConversionHelper.ConvertStringToDateTime(dateOfBirthDateTimePicker.Value.ToString("dd.MM.yyy"))))
            {
                MessageBox.Show(@"You must be at least 18 to make a reservation!");

                return false;
            }

            return true;
        }


        /// <summary>
        /// Creates a new person from the supplied data.
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
