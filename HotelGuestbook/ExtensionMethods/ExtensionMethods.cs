using System.Collections.Generic;
using System.Linq;
using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;

namespace HotelGuestbook.ExtensionMethods
{
    public static class PersonExtensions
    {
        /// <summary>
        /// Returns all reservations for a specified person.
        /// </summary>
        /// <param name="person">Person the reservations of whom to retrieve.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsForPerson(this PersonInfo person)
        {
            return GuestBook.Context.Reservations.Where(reservation => reservation.PersonId == person.PersonId);
        }
    }


    public static class ApartmentExtensions
    {
        /// <summary>
        /// Returns all reservations for a specified apartment.
        /// </summary>
        /// <param name="apartment">Apartment the reservations of which to retrieve.</param>
        public static IEnumerable<ReservationInfo> GetAllReservationsForApartment(this ApartmentInfo apartment)
        {
            return GuestBook.Context.Reservations.Where(reservation => reservation.ApartmentId == apartment.ApartmentId);
        }
    }
}
