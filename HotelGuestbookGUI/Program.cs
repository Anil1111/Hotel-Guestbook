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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HotelGuestbook = new GuestBook("HotelGuestbook");

            //InitializeSampleData();
            
            Application.Run(new Reservations.ReservationsListForm());
        }


        /// <summary>
        /// Initializes sample data.
        /// </summary>
        private static void InitializeSampleData()
        {
            var dataInitializer = new DataInitializer();

            dataInitializer.GenerateTestData(HotelGuestbook, true);
        }
    }
}
