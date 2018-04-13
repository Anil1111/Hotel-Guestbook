using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGuestbookGUI.GDPR
{
    public partial class PersonalDataForm : Form
    {
        public PersonalDataForm(bool showDeleteButton = false)
        {
            InitializeComponent();

            deleteButton.Visible = showDeleteButton;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
