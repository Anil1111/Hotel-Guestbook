using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class AddReservationReviewForm : Form
    {
        public PersonInfo Person;
        public ApartmentInfo Apartment;
        public ReservationInfo Reservation;


        /// <summary>
        /// Creates new instance of AddReservationReviewForm.
        /// </summary>
        /// <param name="person">Person's data to display.</param>
        /// <param name="apartment">Apartment data to display.</param>
        /// <param name="reservation">Reservation details to display.</param>
        public AddReservationReviewForm(PersonInfo person, ApartmentInfo apartment, ReservationInfo reservation)
        {
            InitializeComponent();

            Person = person;
            Apartment = apartment;
            Reservation = reservation;

            InitializeLabelsText();
        }


        #region Events


        private void BackButton_Click(object sender, EventArgs e)
        {
            var addReservationRoomDetailsForm = new AddReservationRoomDetailsForm(Person, Apartment, Reservation);

            addReservationRoomDetailsForm.Show();
            Close();
        }


        private void ReserveButton_Click(object sender, EventArgs e)
        {
            PersonProvider.SetPerson(Person);
            //ApartmentProvider.SetApartment(Apartment);
            ReservationProvider.SetReservation(Reservation);

            MessageBox.Show("Reservation was successful!");
            Close();
        }


        #endregion


        /// <summary>
        /// Initializes the labels text for reservation review.
        /// </summary>
        private void InitializeLabelsText()
        {
            nameLabel.Text = Person.FirstName + Person.LastName;
            emailLabel.Text = Person.Email;
            dateOfBirthLabel.Text = Person.DateOfBirth.ToString("dd.MM.yyyy");
            roomLabel.Text = Apartment.Number.ToString();
            capacityLabel.Text = Apartment.Capacity.ToString();
            doubleBedsLabel.Text = Apartment.DoubleBeds.ToString();
            fromLabel.Text = Reservation.From.ToString("dd.MM.yyyy");
            toLabel.Text = Reservation.To.ToString("dd.MM.yyyy");
            priceLabel.Text = (Apartment.Price * (Reservation.To - Reservation.From).TotalDays).ToString();
        }
    }
}
