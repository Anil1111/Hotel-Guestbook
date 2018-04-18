using System;
using System.Windows.Forms;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Helpers;

namespace HotelGuestbookGUI.Reservations.Add
{
    public partial class AddReservationPersonalDataForm : Form
    {
        private PersonInfo _person;


        /// <summary>
        /// Creates a new instance of AddReservationPersonalDataForm.
        /// </summary>
        /// <param name="person">Person's data to display.</param>
        public AddReservationPersonalDataForm(PersonInfo person = null)
        {
            InitializeComponent();

            proceedButton.Enabled = false;
            infoLabel.Text = @"";

            if (person != null)
            {
                SetFields(person);
            }
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


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show(@"Email is either empty or is in incorrect format.");

                return;
            }

            _person = PersonProvider.GetPersonByEmail(emailTextBox.Text);

            if (_person != null)
            {
                SetFields(_person);

                emailTextBox.Enabled = false;

                ChangeTextBoxesAvailability(string.Empty, false);
            }
            else
            {
                ChangeTextBoxesAvailability(@"Email not found", true);
            }

            proceedButton.Enabled = true;
        }


        #endregion


        /// <summary>
        /// Sets the field values.
        /// </summary>
        /// <param name="person">Person the information of which to use.</param>
        private void SetFields(PersonInfo person)
        {
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
            emailTextBox.Text = person.Email;
            dateOfBirthDateTimePicker.Value = person.DateOfBirth;

            proceedButton.Enabled = true;

            ChangeTextBoxesAvailability("", true);
        }


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
        /// Change the text boxes availability according to <paramref name="value"/>.
        /// </summary>
        /// <param name="text">Label text.</param>
        /// <param name="value">True if text boxes should be enabled.</param>
        private void ChangeTextBoxesAvailability(string text, bool value)
        {
            infoLabel.Text = text;

            firstNameTextBox.Enabled = value;
            lastNameTextBox.Enabled = value;
            dateOfBirthDateTimePicker.Enabled = value;
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

            return new PersonInfo(firstName, lastName, email, dateOfBirth);
        }
    }
}
