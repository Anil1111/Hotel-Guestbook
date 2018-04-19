using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelGuestbookGUI.Reservations.Edit
{
    public partial class EditReservationForm : Form
    {
        private ApartmentInfo _apartment;
        private ReservationInfo _reservation;
        private readonly List<ApartmentInfo> _apartments = ApartmentProvider.GetAllApartments().ToList();


        public EditReservationForm(ListViewItem listViewItem)
        {
            InitializeComponent();

            ListViewItemToReservation(listViewItem);

            InitializeValues();

            saveButton.Enabled = false;
        }


        #region Events


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ApartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _apartment = _apartments[apartmentsComboBox.SelectedIndex];

            CheckApartmentAvailability();
        }


        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fromDateTimePicker.Value >= toDateTimePicker.Value)
            {
                toDateTimePicker.Value = fromDateTimePicker.Value.AddDays(1);
            }

            CheckApartmentAvailability();
        }


        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (toDateTimePicker.Value <= fromDateTimePicker.Value)
            {
                fromDateTimePicker.Value = toDateTimePicker.Value.AddDays(-1);
            }

            CheckApartmentAvailability();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            _reservation.Apartment = _apartment;
            _reservation.ApartmentId = _apartment.ApartmentId;

            _reservation.From = fromDateTimePicker.Value;
            _reservation.To = toDateTimePicker.Value;

            ReservationProvider.SetReservation(_reservation);

            Close();
        }


        #endregion



        /// <summary>
        /// Initializes values for edit.
        /// </summary>
        private void InitializeValues()
        {
            foreach (var apartment in _apartments)
            {
                apartmentsComboBox.Items.Add(apartment.ToDropDownString());
            }

            infoLabel.Text = "";
            originalRoomLabel.Text = @"Original room number: " + _reservation.Apartment.Number;

            fromDateTimePicker.Value = _reservation.From;
            toDateTimePicker.Value = _reservation.To;
        }


        /// <summary>
        /// Transforms the <paramref name="listViewItem"/> to a reservation.
        /// </summary>
        /// <param name="listViewItem">Selected item to transform.</param>
        private void ListViewItemToReservation(ListViewItem listViewItem)
        {
            var reservationId = Convert.ToInt32(listViewItem.SubItems[0].Text);

            _reservation = ReservationProvider.GetReservationById(reservationId);
        }


        /// <summary>
        /// Checks if the selected apartment is available within the selected dates.
        /// </summary>
        private void CheckApartmentAvailability()
        {
            if (_apartment == null)
            {
                return;
            }

            var start = fromDateTimePicker.Value.Date;
            var end = toDateTimePicker.Value.Date;

            var reservations = _apartment.GetAllReservationsForApartment().Except(new List<ReservationInfo> { _reservation }).ToList();

            foreach (var reservation in reservations)
            {
                if ((reservation.From < start && reservation.To > start) ||
                    (reservation.From < end && reservation.To > end)     ||
                    (start <= reservation.From && end >= reservation.To))
                {
                    infoLabel.Text = @"Selected reservation dates for this room collide with another reservation.\r\n" 
                                     + $@"Reservation start: {reservation.From.Date:dd.MM.yyyy}, reservation end: {reservation.To.Date:dd.MM.yyyy}";

                    saveButton.Enabled = false;

                    return;
                }

                infoLabel.Text = "";
                saveButton.Enabled = true;
            }
        }
    }
}
