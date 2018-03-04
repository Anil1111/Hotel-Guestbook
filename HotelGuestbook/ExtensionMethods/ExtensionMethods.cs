using System;
using System.Collections.Generic;
using HotelGuestbook.ExtensionMethods.Apartment;
using HotelGuestbook.ExtensionMethods.Person;
using HotelGuestbook.ExtensionMethods.Reservation;

namespace HotelGuestbook.ExtensionMethods
{
    public static class PersonExtensions
    {
        /// <summary>
        /// Returns all reservations for a specified person.
        /// </summary>
        /// <param name="person">Person the reservations of whom to retrieve.</param>
        public static IEnumerable<ReservationInfo> GetAllReservations(this PersonInfo person)
        {
            throw new NotImplementedException();
        }
    }


    public static class ApartmentExtensions
    {
        /// <summary>
        /// Returns all reservations for a specified apartment.
        /// </summary>
        /// <param name="apartment">Apartment the reservations of which to retrieve.</param>
        public static IEnumerable<ReservationInfo> GetAllReservations(this ApartmentInfo apartment)
        {
            throw new NotImplementedException();
        }
    }
}
