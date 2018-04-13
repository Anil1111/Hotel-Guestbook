using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class AddReservationRoomDetailsForm : Form
    {
        public AddReservationRoomDetailsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDetailsForm = new addReservationPersonalDataForm();

            addReservationPersonalDetailsForm.Show();
            Close();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            var addReservationReviewForm = new AddReservationReviewForm();

            addReservationReviewForm.Show();
            Close();
        }
    }
}
