using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.ExtensionMethods;
using HotelGuestbook.Helpers;

namespace HotelGuestbookGUI.GDPR
{
    public partial class PersonalDataForm : Form
    {
        private string Email;
        private PersonInfo Person;
        private List<ReservationInfo> Reservations;


        /// <summary>
        /// Creates a new instance of PersonalDataForm.
        /// </summary>
        /// <param name="showDeleteButton">If true, the delete button is shown.</param>
        public PersonalDataForm(bool showDeleteButton = false)
        {
            InitializeComponent();

            if (showDeleteButton)
            {
                deleteButton.Visible = true;
                deleteButton.Enabled = false;
            }
        }


        #region Events


        private void CloseButton_Click(object sender, EventArgs e) => Close();


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!ValidateEmail(emailTextBox.Text))
            {
                return;
            }

            Email = emailTextBox.Text;
            Person = PersonProvider.GetPersonByEmail(Email);

            if (Person == null)
            {
                dataTextBox.Text = @"No data found";
            }
            else
            {
                SearchAndWriteData(Person);

                deleteButton.Enabled = true;
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            PersonProvider.AnonymizePerson(Person);

            MessageBox.Show(@"Data deleted successfully");
        }


        #endregion


        /// <summary>
        /// Searches for reservation of <paramref name="person"/>.
        /// </summary>
        /// <param name="person"></param>
        private void SearchAndWriteData(PersonInfo person)
        {
            Reservations = Person.GetAllReservationsForPerson().ToList();

            var sb = new StringBuilder();

            sb.AppendLine($"Email: {Person.Email}");
            sb.AppendLine($"Name: {Person.FirstName} {person.LastName}");
            sb.AppendLine($"Date of birth: {Person.DateOfBirth:dd.MM.yyyy}");
            sb.AppendLine("Reservations:");

            Reservations.ForEach(reservation => AppendReservation(ref sb, reservation));

            dataTextBox.Text = sb.ToString();
        }


        /// <summary>
        /// Adds persons reservation to the output.
        /// </summary>
        /// <param name="sb">StringBuilder instance.</param>
        /// <param name="reservation">Reservation to write.</param>
        private static void AppendReservation(ref StringBuilder sb, ReservationInfo reservation)
        {
            sb.AppendLine($"    Room number: {reservation.Apartment.Number}");
            sb.AppendLine($"    From {reservation.From:dd.MM.yyyy}");
            sb.AppendLine($"    To {reservation.To:dd.MM.yyyy}");
            sb.AppendLine();
        }


        /// <summary>
        /// Validates email.
        /// </summary>
        /// <param name="email">Email to validate.</param>
        private static bool ValidateEmail(string email)
        {
            var validEmail = ValidationHelper.IsValidEmail(email);

            if (!validEmail)
            {
                MessageBox.Show(@"Incorrect email");

                return false;
            }

            return true;
        }
    }
}
