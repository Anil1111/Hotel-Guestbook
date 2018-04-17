using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI.GDPR
{
    public partial class PersonalDataForm : Form
    {
        /// <summary>
        /// Creates a new instance of PersonalDataForm.
        /// </summary>
        /// <param name="showDeleteButton">If true, the delete button is shown.</param>
        public PersonalDataForm(bool showDeleteButton = false)
        {
            InitializeComponent();

            deleteButton.Visible = showDeleteButton;
        }


        #region Events


        private void CloseButton_Click(object sender, EventArgs e) => Close();


        #endregion
    }
}
