using HotelGuestbook.DAL;
using System;
using System.Windows.Forms;

namespace HotelGuestbookGUI
{
    public static class Program
    {
        public static GuestBook HotelGuestbook { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HotelGuestbook = new GuestBook("HotelGuestbook");

            Application.Run(new Reservations.ReservationsListForm());
        }
    }
}
