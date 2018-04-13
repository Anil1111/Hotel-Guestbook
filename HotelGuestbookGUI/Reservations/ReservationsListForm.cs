using HotelGuestbook.DAL;
using HotelGuestbookGUI.GDPR;
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
    public partial class ReservationsListForm : Form
    {
        public GuestBook HotelGuestbook { get; set; }


        public ReservationsListForm()
        {
            InitializeComponent();

            HotelGuestbook = new GuestBook("HotelGuestbook");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }


        private void ExitApplication()
        {
            GuestBook.Context.Database.Connection.Close();
            GuestBook.Context.Dispose();

            Application.Exit();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gdprHelpForm = new HelpForm();

            gdprHelpForm.Show();
        }


        private void rightToAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personalDataForm = new PersonalDataForm();

            personalDataForm.Show();
        }


        private void rightToBeForgottenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personalDataForm = new PersonalDataForm(true);

            personalDataForm.Show();
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDataForm = new addReservationPersonalDataForm();

            addReservationPersonalDataForm.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.ShowDialog();
        }
    }
}
