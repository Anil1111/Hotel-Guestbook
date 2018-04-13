using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;
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
    public partial class SearchApartmentForm : Form
    {
        private int MinimalCapacity;
        private int DoubleBeds;
        private DateTime From;
        private DateTime To;

        public SearchApartmentForm()
        {
            InitializeComponent();
        }

        public SearchApartmentForm(decimal minimalCapacity, decimal doubleBeds, DateTime from, DateTime to)
        {
            InitializeComponent();

            MinimalCapacity = Int32.Parse(minimalCapacity.ToString());
            DoubleBeds = Int32.Parse(doubleBeds.ToString());
            From = from;
            To = to;

            ListApartments(MinimalCapacity, DoubleBeds, From, To);
        }

        private void ListApartments(int minimalCapacity, int doubleBeds, DateTime from, DateTime to)
        {
            var avaliableApartments = ApartmentProvider.GetApartmentsWithCapacityAtLeast(minimalCapacity)
                                                       .Where(apartment => apartment.DoubleBeds >= doubleBeds)
                                                       .ToList();
            var reservations = ReservationProvider.GetAllReservationsFrom(from).Where(reservation => reservation.To <= to);
            var occupiedApartments = new List<ApartmentInfo>();

            foreach (var reservation in reservations)
            {
                if (!occupiedApartments.Contains(reservation.Apartment))
                {
                    occupiedApartments.Add(reservation.Apartment);
                }
            }

            apartmentsListBox = new ListBox();

            apartmentsListBox.Items.Clear();
            foreach (var apartment in avaliableApartments)
            {
                apartmentsListBox.Items.Add(apartment.ToString());
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
