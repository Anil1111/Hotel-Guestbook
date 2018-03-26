using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Reservation
{
    public static class ReservationProvider
    {
        /// <summary>
        /// Returns a reservation by its ID.
        /// </summary>
        /// <param name="id">ID of the reservation.</param>
        public static ReservationInfo GetReservationById(int id)
        {
            return GuestBook.Context.Reservations.FirstOrDefault(reservation => reservation.ReservationId == id);
        }


        /// <summary>
        /// Returns all reservations from a certain date.
        /// </summary>
        /// <param name="from">Starting date.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsFrom(DateTime from)
        {
            return GuestBook.Context.Reservations.Where(reservation => reservation.From >= from);
        }


        /// <summary>
        /// Returns all reservations till a certain date.
        /// </summary>
        /// <param name="till">Ending day.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsTill(DateTime till)
        {
            return GuestBook.Context.Reservations.Where(reservation => reservation.To <= till);
        }


        /// <summary>
        /// Saves the <paramref name="reservation"/> to the database.
        /// </summary>
        /// <param name="reservation">Reservation to be saved.</param>
        public static void SetReservation(ReservationInfo reservation)
        {
            GuestBook.Context.Reservations.Add(reservation);
            GuestBook.Context.SaveChanges();
        }
    }
}
