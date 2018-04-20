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
        private ApartmentInfo Apartment;
        private ReservationInfo Reservation;
        private readonly List<ApartmentInfo> Apartments = ApartmentProvider.GetAllApartments().ToList();


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
            Apartment = Apartments[apartmentsComboBox.SelectedIndex];

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
            Reservation.Apartment = Apartment;
            Reservation.ApartmentId = Apartment.ApartmentId;

            Reservation.From = fromDateTimePicker.Value;
            Reservation.To = toDateTimePicker.Value;

            ReservationProvider.UpdateReservation(Reservation);

            Close();
        }


        #endregion



        /// <summary>
        /// Initializes values for edit.
        /// </summary>
        private void InitializeValues()
        {
            foreach (var apartment in Apartments)
            {
                apartmentsComboBox.Items.Add(apartment.ToDropDownString());
            }

            infoLabel.Text = "";
            originalRoomLabel.Text = @"Original room number: " + Reservation.Apartment.Number;

            fromDateTimePicker.Value = Reservation.From;
            toDateTimePicker.Value = Reservation.To;
        }


        /// <summary>
        /// Transforms the <paramref name="listViewItem"/> to a reservation.
        /// </summary>
        /// <param name="listViewItem">Selected item to transform.</param>
        private void ListViewItemToReservation(ListViewItem listViewItem)
        {
            var reservationId = Convert.ToInt32(listViewItem.SubItems[0].Text);

            Reservation = ReservationProvider.GetReservationById(reservationId);
        }


        /// <summary>
        /// Checks if the selected apartment is available within the selected dates.
        /// </summary>
        private void CheckApartmentAvailability()
        {
            if (Apartment == null)
            {
                return;
            }

            var start = fromDateTimePicker.Value.Date;
            var end = toDateTimePicker.Value.Date;

            var reservations = Apartment.GetAllReservationsForApartment().Except(new List<ReservationInfo> { Reservation }).ToList();

            foreach (var reservation in reservations)
            {
                if ((reservation.From < start && reservation.To > start) ||
                    (reservation.From < end && reservation.To > end)     ||
                    (start <= reservation.From && end >= reservation.To))
                {
                    infoLabel.Text = $@"Selected reservation dates for this room collide with another reservation.
Reservation start: {reservation.From.Date:dd.MM.yyyy}, reservation end: {reservation.To.Date:dd.MM.yyyy}";

                    saveButton.Enabled = false;

                    return;
                }

                infoLabel.Text = "";
                saveButton.Enabled = true;
            }
        }
    }
}
