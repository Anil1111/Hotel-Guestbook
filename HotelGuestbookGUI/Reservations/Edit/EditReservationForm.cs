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
        private ApartmentInfo apartment;
        private ReservationInfo reservation;
        private List<ApartmentInfo> apartments = ApartmentProvider.GetAllApartments().ToList();


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
            apartment = apartments[apartmentsComboBox.SelectedIndex];

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
            reservation.Apartment = apartment;
            reservation.ApartmentId = apartment.ApartmentId;

            reservation.From = fromDateTimePicker.Value;
            reservation.To = toDateTimePicker.Value;

            ReservationProvider.SetReservation(reservation);

            Close();
        }


        #endregion



        /// <summary>
        /// Initializes values for editation.
        /// </summary>
        private void InitializeValues()
        {
            foreach (var apartment in apartments)
            {
                apartmentsComboBox.Items.Add(apartment.ToDropDownString());
            }

            infoLabel.Text = "";
            originalRoomLabel.Text = "Original room number: " + reservation.Apartment.Number.ToString();

            fromDateTimePicker.Value = reservation.From;
            toDateTimePicker.Value = reservation.To;
        }


        /// <summary>
        /// Transforms the <paramref name="listViewItem"/> to a reservation.
        /// </summary>
        /// <param name="listViewItem">Selected item to transform.</param>
        private void ListViewItemToReservation(ListViewItem listViewItem)
        {
            var reservationId = Convert.ToInt32(listViewItem.SubItems[0].Text);

            reservation = ReservationProvider.GetReservationById(reservationId);
        }


        /// <summary>
        /// Checks if the selected apartment is available within the selected dates.
        /// </summary>
        private void CheckApartmentAvailability()
        {
            if (apartment == null)
            {
                return;
            }

            var start = fromDateTimePicker.Value.Date;
            var end = toDateTimePicker.Value.Date;

            var reservations = apartment.GetAllReservationsForApartment().ToList();

            foreach (var reservation in reservations)
            {
                if ((reservation.From < start && reservation.To > start) ||
                    (reservation.From < end && reservation.To > end)     ||
                    (start <= reservation.From && end >= reservation.To))
                {
                    infoLabel.Text = $"Selected reservation dates for this room collide with another reservation.\r\n" 
                                     + $"Reservation start: {reservation.From.Date.ToString("dd.MM.yyyy")}, reservation end: {reservation.To.Date.ToString("dd.MM.yyyy")}";

                    saveButton.Enabled = false;

                    return;
                }

                infoLabel.Text = "";
                saveButton.Enabled = true;
            }
        }
    }
}
