using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.GDPR
{
    public partial class HelpForm : Form
    {
        /// <summary>
        /// Creates a new instance of HelpForm.
        /// </summary>
        public HelpForm()
        {
            InitializeComponent();
        }


        #region Events


        private void CloseButton_Click(object sender, EventArgs e) => Close();


        #endregion
    }
}
