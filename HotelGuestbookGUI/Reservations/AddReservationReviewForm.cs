using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class AddReservationReviewForm : Form
    {
        public AddReservationReviewForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var addReservationRoomDetailsForm = new AddReservationRoomDetailsForm();

            addReservationRoomDetailsForm.Show();
            Close();
        }
    }
}
