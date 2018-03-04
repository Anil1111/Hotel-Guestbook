using System;
using System.Collections.Generic;

namespace HotelGuestbook.ExtensionMethods.Reservation
{
    public static class ReservationProvider
    {
        /// <summary>
        /// Returns a reservation by its ID.
        /// </summary>
        /// <param name="id">ID of the resetvation.</param>
        public static ReservationInfo GetReservationById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all reservations from a certain date.
        /// </summary>
        /// <param name="from">Starting date.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsFrom(DateTime from)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all reservations till a certain date.
        /// </summary>
        /// <param name="till">Ending day.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsTill(DateTime till)
        {
            throw new NotImplementedException();
        }
    }
}
