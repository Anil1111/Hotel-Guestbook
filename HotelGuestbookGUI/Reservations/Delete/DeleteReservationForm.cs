using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations.Delete
{
    public partial class DeleteReservationForm : Form
    {
        private PersonInfo person;
        private ReservationInfo reservation;


        public DeleteReservationForm(ListViewItem listViewItem)
        {
            InitializeComponent();

            ListViewItemToReservation(listViewItem);

            SetUpLabels();
        }


        private void SetUpLabels()
        {
            nameTextLabel.Text = person.FirstName + " " + person.LastName;
            emailTextLabel.Text = person.Email;
        }


        private void ListViewItemToReservation(ListViewItem listViewItem)
        {
            var email = listViewItem.SubItems[2].Text;
            var roomNumber = Convert.ToInt32(listViewItem.SubItems[4].Text);
            var from = Convert.ToDateTime(listViewItem.SubItems[5].Text);
            var to = Convert.ToDateTime(listViewItem.SubItems[5].Text);
            var reservation = ReservationProvider.GetReservationsByRoomNumber(roomNumber)
                                                 .Where(r => r.From.Date.Equals(from.Date))
                                                 .Where(s => s.To.Date.Equals(to.Date));

            person = PersonProvider.GetPersonByEmail(email);
        }


        private void DeleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = deleteCheckBox.Checked;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ReservationProvider.DeleteReservation(reservation);
        }
    }
}
