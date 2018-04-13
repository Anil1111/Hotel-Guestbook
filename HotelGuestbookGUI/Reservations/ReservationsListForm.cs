using HotelGuestbook.DAL;
using HotelGuestbookGUI.GDPR;
using System;
using System.Linq;
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

            ChangeSearchAvailability(false);

            SetUpHeaders();

            RefreshGUI();
        }


        #region Click events


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
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
            var addReservationPersonalDataForm = new AddReservationPersonalDataForm();

            addReservationPersonalDataForm.Show();
        }


        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.ShowDialog();
        }


        private void pastReservationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGUI(pastReservationsCheckBox.Checked);
        }


        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSearchTextBoxAccessibility();
        }


        private void searchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
  
            ChangeSearchAvailability(searchCheckBox.Checked);

            fromCheckBox_CheckedChanged(sender, e);
            toCheckBox_CheckedChanged(sender, e);

            RefreshGUI();
        }


        private void fromCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.Enabled = searchCheckBox.Checked && fromCheckBox.Checked;

            ChangePastReservationsAvailability(fromCheckBox.Checked || toCheckBox.Checked);
        }


        private void toCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toDateTimePicker.Enabled = searchCheckBox.Checked && toCheckBox.Checked;

            ChangePastReservationsAvailability(fromCheckBox.Checked || toCheckBox.Checked);
        }


        #endregion


        /// <summary>
        /// Refreshes the list of reservations.
        /// </summary>
        /// <param name="showPastReservations">If true, past reservations are shown in GUI.</param>
        private void RefreshGUI(bool showPastReservations = false)
        {
            reservationsListView.Items.Clear();

            foreach (var reservation in HotelGuestbook.Reservations)
            {
                if (!showPastReservations && reservation.From < DateTime.Today)
                {
                    continue;
                }

                var row = reservation.ToString().Split(';');
                var listViewItem = new ListViewItem(row);
                reservationsListView.Items.Add(listViewItem);
            }

            if (showPastReservations)
            {
                countLabel.Text = HotelGuestbook.Reservations.Count().ToString();
            }
            else
            {
                countLabel.Text = HotelGuestbook.Reservations.Where(reservation => reservation.From >= DateTime.Today).Count().ToString();
            }
        }


        /// <summary>
        /// Sets up the list view headers.
        /// </summary>
        private void SetUpHeaders()
        {
            reservationsListView.Columns.Add(CreateColumnHeader("First name", 100));
            reservationsListView.Columns.Add(CreateColumnHeader("Last name", 100));
            reservationsListView.Columns.Add(CreateColumnHeader("Email", 170));
            reservationsListView.Columns.Add(CreateColumnHeader("Date of birth", 100));
            reservationsListView.Columns.Add(CreateColumnHeader("Room number", 80));
            reservationsListView.Columns.Add(CreateColumnHeader("From", 80));
            reservationsListView.Columns.Add(CreateColumnHeader("To", 80));

            reservationsListView.View = View.Details;
        }


        /// <summary>
        /// Returns a new instance of list view header.
        /// </summary>
        /// <param name="headerText">Header text.</param>
        /// <param name="width">Header width.</param>
        private ColumnHeader CreateColumnHeader(string headerText, int width)
        {
            return new ColumnHeader
            {
                Text = headerText,
                Width = width
            };
        }


        /// <summary>
        /// Changes the search text box to either enabled or disabled based on selected value in <code>searchComboBox</code>
        /// </summary>
        private void ChangeSearchTextBoxAccessibility()
        {
            if (searchComboBox.SelectedIndex <= 0 || !searchCheckBox.Checked)
            {
                searchTextBox.Enabled = false;

                return;
            }

            searchTextBox.Enabled = true;
        }


        /// <summary>
        /// Enables or disables search based on <paramref name="availability"/>.
        /// </summary>
        /// <param name="availability">Indicates id search is available.</param>
        private void ChangeSearchAvailability(bool availability)
        {
            searchComboBox.Enabled = availability;
            ChangeSearchTextBoxAccessibility();

            fromCheckBox.Enabled = availability;
            fromDateTimePicker.Enabled = availability;

            toCheckBox.Enabled = availability;
            toDateTimePicker.Enabled = availability;
        }


        /// <summary>
        /// Changes the past events availability based on <paramref name="enabled"/>.
        /// </summary>
        /// <param name="enabled">Indicated if past events should be visible.</param>
        private void ChangePastReservationsAvailability(bool enabled)
        {
            if (enabled)
            {
                pastReservationsCheckBox.Checked = true;
                pastReservationsCheckBox.Enabled = false;
            }
            else
            {
                pastReservationsCheckBox.Checked = false;
                pastReservationsCheckBox.Enabled = true;
            }

            RefreshGUI(enabled);
        }


        /// <summary>
        /// Disposes the context and exits the application.
        /// </summary>
        private void ExitApplication()
        {
            GuestBook.Context.Database.Connection.Close();
            GuestBook.Context.Dispose();

            Application.Exit();
        }
    }
}
