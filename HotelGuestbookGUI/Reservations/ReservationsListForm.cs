﻿using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;
using HotelGuestbookGUI.GDPR;
using HotelGuestbookGUI.Reservations.Delete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations
{
    public partial class ReservationsListForm : Form
    {
        public GuestBook HotelGuestbook { get; set; }
        private IEnumerable<ReservationInfo> FilteredReservations;

        private bool editMode = false;
        private bool deleteMode = false;


        public ReservationsListForm()
        {
            InitializeComponent();

            HotelGuestbook = new GuestBook("HotelGuestbook");

            reservationsListView.MultiSelect = false;
            endEditOrDeleteModeButton.Visible = false;

            InitializeImageList();

            ChangeSearchAvailability(false);

            SetUpHeaders();

            RefreshGUI();

            FilteredReservations = ReservationProvider.GetAllReservations();
        }


        #region Events


        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.ShowDialog();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }


        private void RightToAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personalDataForm = new PersonalDataForm();

            personalDataForm.Show();
        }


        private void RightToBeForgottenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personalDataForm = new PersonalDataForm(true);

            personalDataForm.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gdprHelpForm = new HelpForm();

            gdprHelpForm.Show();
        }


        private void PastReservationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }


        private void SearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
  
            ChangeSearchAvailability(searchCheckBox.Checked);

            FromCheckBox_CheckedChanged(sender, e);
            fromCheckBox.Enabled = searchCheckBox.Checked;

            ToCheckBox_CheckedChanged(sender, e);
            toCheckBox.Enabled = searchCheckBox.Checked;

            if (searchCheckBox.Checked)
            {
                RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
            }
            else
            {
                RefreshGUI(null, pastReservationsCheckBox.Checked);
            }
        }


        private void FromCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.Enabled = searchCheckBox.Checked && fromCheckBox.Checked;

            UpdateSearch();
        }


        private void ToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toDateTimePicker.Enabled = searchCheckBox.Checked && toCheckBox.Checked;

            UpdateSearch();
        }


        private void SearchComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }


        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }


        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addReservationPersonalDataForm = new AddReservationPersonalDataForm();

            addReservationPersonalDataForm.Show();
        }


        private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editMode = true;

            modeLabel.Text = "The application is in edit mode";

            endEditOrDeleteModeButton.Text = "End edit mode";
            endEditOrDeleteModeButton.Visible = true;

            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
        }


        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteMode = true;

            modeLabel.Text = "The application is in delete mode";

            endEditOrDeleteModeButton.Text = "End delete mode";
            endEditOrDeleteModeButton.Visible = true;

            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
        }


        private void EndEditOrDeleteModeButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                editMode = false;
                endEditOrDeleteModeButton.Visible = false;
            }

            if (deleteMode)
            {
                deleteMode = false;
                endEditOrDeleteModeButton.Visible = false;
            }

            modeLabel.Text = String.Empty;

            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
        }


        #endregion


        /// <summary>
        /// Refreshes the list of reservations.
        /// </summary>
        /// <param name="showPastReservations">If true, past reservations are shown in GUI.</param>
        private void RefreshGUI(IEnumerable<ReservationInfo> reservations = null, bool showPastReservations = false)
        {
            reservationsListView.Items.Clear();

            AddReservationsToListView(reservations, showPastReservations);

            AddIcons();

            UpdateCountLabel();
        }


        /// <summary>
        /// Adds edit or delete icons based on which mode is the application currently operating in.
        /// </summary>
        private void AddIcons()
        {
            if (editMode)
            {
                foreach (ListViewItem item in reservationsListView.Items)
                {
                    item.ImageIndex = 0;
                }
            }

            if (deleteMode)
            {
                foreach (ListViewItem item in reservationsListView.Items)
                {
                    item.ImageIndex = 1;
                }
            }
        }


        /// <summary>
        /// Initializes the image list for the list view.
        /// </summary>
        private void InitializeImageList()
        {
            var imageList = new ImageList();

            imageList.Images.Add(Image.FromFile(Path.Combine(Assembly.GetExecutingAssembly().Location, @"../../../Icons/edit.ico")));
            imageList.Images.Add(Image.FromFile(Path.Combine(Assembly.GetExecutingAssembly().Location, @"../../../Icons/delete.ico")));

            reservationsListView.SmallImageList = imageList;
        }


        /// <summary>
        /// Adds reservations to the list view.
        /// </summary>
        /// <param name="showPastReservations">If true, past reservations are shown in GUI.</param>
        private void AddReservationsToListView(IEnumerable<ReservationInfo> reservations = null, bool showPastReservations = false)
        {
            var listOfReservations = reservations ?? HotelGuestbook.Reservations;

            foreach (var reservation in listOfReservations)
            {
                if (!showPastReservations && reservation.From < DateTime.Today)
                {
                    continue;
                }

                var row = reservation.ToString().Split(';');
                var listViewItem = new ListViewItem(row);

                reservationsListView.Items.Add(listViewItem);
            }
        }


        /// <summary>
        /// Updates the count label.
        /// </summary>
        private void UpdateCountLabel()
        {
            countLabel.Text = reservationsListView.Items.Count.ToString();
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

            reservationsListView.FullRowSelect = true;
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
        /// Enables or disables search based on <paramref name="availability"/>.
        /// </summary>
        /// <param name="availability">Indicates id search is available.</param>
        private void ChangeSearchAvailability(bool availability)
        {
            searchComboBox.Enabled = availability;
            searchTextBox.Enabled = availability;

            fromDateTimePicker.Enabled = fromCheckBox.Enabled;
            toDateTimePicker.Enabled = toCheckBox.Enabled;
        }


        /// <summary>
        /// Updates the search results.
        /// </summary>
        private void UpdateSearch()
        {
            FilteredReservations = ReservationProvider.GetAllReservations();

            if (searchCheckBox.Checked)
            {
                FilterBySearchParameters();

                FilterByDate();
            }

            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
        }


        /// <summary>
        /// Filters reservations by search parameters.
        /// </summary>
        private void FilterBySearchParameters()
        {
            switch (searchComboBox.SelectedIndex)
            {
                case 0:
                    {
                        FilteredReservations = ReservationProvider.GetReservationsByFirstName(searchTextBox.Text);
                        RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
                        break;
                    }
                case 1:
                    {
                        FilteredReservations = ReservationProvider.GetReservationsByLastName(searchTextBox.Text);
                        RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
                        break;
                    }
                case 2:
                    {
                        FilteredReservations = ReservationProvider.GetReservationsByEmail(searchTextBox.Text);
                        RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
                        break;
                    }
                case 3:
                    {
                        FilteredReservations = ReservationProvider.GetReservationsByRoomNumber(Int32.Parse(searchTextBox.Text));
                        RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
                        break;
                    }
            }
        }


        /// <summary>
        /// Filters reservations by date.
        /// </summary>
        private void FilterByDate()
        {
            if (fromCheckBox.Checked)
            {
                FilteredReservations = FilteredReservations.Where(reservation => (reservation.From.Date - fromDateTimePicker.Value.Date).TotalDays >= 0);
            }

            if (toCheckBox.Checked)
            {
                FilteredReservations = FilteredReservations.Where(reservation => (reservation.To.Date - toDateTimePicker.Value.Date).TotalDays <= 0);
            }

            RefreshGUI(FilteredReservations, pastReservationsCheckBox.Checked);
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

        private void reservationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deleteMode)
            {
                var deleteReservationForm = new DeleteReservationForm(reservationsListView.SelectedItems[0]);

                deleteReservationForm.Show();
            }
        }
    }
}
