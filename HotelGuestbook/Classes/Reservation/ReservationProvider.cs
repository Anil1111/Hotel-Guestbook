using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Reservation
{
    public static class ReservationProvider
    {
        /// <summary>
        /// Returns all reservations in the database.
        /// </summary>
        public static IEnumerable<ReservationInfo> GetAllReservations() => GuestBook.Context.Reservations;


        /// <summary>
        /// Returns a reservation by its ID.
        /// </summary>
        /// <param name="id">ID of the reservation.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="id"/> is invalid.</exception>
        public static ReservationInfo GetReservationById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            return GuestBook.Context.Reservations.FirstOrDefault(reservation => reservation.ReservationId == id);
        }


        /// <summary>
        /// Returns all reservations from a certain date.
        /// </summary>
        /// <param name="from">Starting date.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="from"/> is null.</exception>
        public static IEnumerable<ReservationInfo> GetAllReservationsFrom(DateTime from)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.From >= from);
        }


        /// <summary>
        /// Returns all reservations till a certain date.
        /// </summary>
        /// <param name="till">Ending day.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="till"/> is null.</exception
        public static IEnumerable<ReservationInfo> GetAllReservationsTill(DateTime till)
        {
            if (till == null)
            {
                throw new ArgumentNullException(nameof(till));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.To < till);
        }


        /// <summary>
        /// Gets all reservations for persons whose first name contains the <paramref name="firstName"/>.
        /// </summary>
        /// <param name="firstName">Whole or partial first name.</param>
        public static IEnumerable<ReservationInfo> GetReservationsByFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.Person.FirstName.Contains(firstName));
        }


        /// <summary>
        /// Gets all reservations for persons whose last name contains the <paramref name="lastName"/>.
        /// </summary>
        /// <param name="lastName">Whole or partial last name.</param>
        public static IEnumerable<ReservationInfo> GetReservationsByLastName(string lastName)
        {
            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.Person.LastName.Contains(lastName));
        }


        /// <summary>
        /// Gets all reservations for persons whose email contains the <paramref name="email"/>.
        /// </summary>
        /// <param name="email">Whole or partial email.</param>
        public static IEnumerable<ReservationInfo> GetReservationsByEmail(string email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.Person.Email.Contains(email));
        }


        /// <summary>
        /// Gets all reservations for <paramref name="roomNumber"/>.
        /// </summary>
        /// <param name="roomNumber">Number of the room to get reservations for.</param>
        public static IEnumerable<ReservationInfo> GetReservationsByRoomNumber(int roomNumber)
        {
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber));
            }

            return GuestBook.Context.Reservations.Where(reservation => reservation.Apartment.Number == roomNumber);
        }


        /// <summary>
        /// Saves the <paramref name="reservation"/> to the database.
        /// </summary>
        /// <param name="reservation">Reservation to be saved.</param>
        /// <remarks>The method does nothing if <paramref name="reservation"/> is null.</remarks
        public static void SetReservation(ReservationInfo reservation)
        {
            if (reservation is null)
            {
                return;
            }

            GuestBook.Context.Reservations.Add(reservation);
            GuestBook.Context.SaveChanges();
        }


        /// <summary>
        /// Deletes the <paramref name="reservation"/> from the database.
        /// </summary>
        /// <param name="reservation">Reservation to be deleted.</param>
        /// <remarks>The method does nothing if <paramref name="reservation"/> is null.</remarks>
        public static void DeleteReservation(ReservationInfo reservation)
        {
            if (reservation is null)
            {
                return;
            }

            GuestBook.Context.Reservations.Remove(reservation);
            GuestBook.Context.SaveChanges();
        }
    }
}
