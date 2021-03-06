﻿using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations.Delete
{
    public partial class DeleteReservationForm : Form
    {
        private PersonInfo Person;
        private ReservationInfo Reservation;


        public DeleteReservationForm(ListViewItem listViewItem)
        {
            InitializeComponent();

            ListViewItemToReservation(listViewItem);

            SetUpLabels();
        }


        #region Events


        private void DeleteCheckBox_CheckedChanged(object sender, EventArgs e) => deleteButton.Enabled = deleteCheckBox.Checked;


        private void CancelButton_Click(object sender, EventArgs e) => Close();


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ReservationProvider.DeleteReservation(Reservation);

            MessageBox.Show(@"The reservation was successfully deleted");

            Close();
        }


        #endregion


        /// <summary>
        /// Sets up labels text.
        /// </summary>
        private void SetUpLabels()
        {
            nameTextLabel.Text = Person.FirstName + @" " + Person.LastName;
            emailTextLabel.Text = Person.Email;

            roomNumberLabel.Text = Reservation.Apartment.Number.ToString();
            fromTextLabel.Text = Reservation.From.Date.ToString("dd.MM.yyyy");
            toTextLabel.Text = Reservation.To.Date.ToString("dd.MM.yyyy");
        }


        /// <summary>
        /// Transforms the <paramref name="listViewItem"/> to a reservation.
        /// </summary>
        /// <param name="listViewItem">Selected item to transform.</param>
        private void ListViewItemToReservation(ListViewItem listViewItem)
        {
            var email = listViewItem.SubItems[3].Text;
            var reservationId = Convert.ToInt32(listViewItem.SubItems[0].Text);

            Person = PersonProvider.GetPersonByEmail(email);
            Reservation = ReservationProvider.GetReservationById(reservationId);         
        }
    }
}
