using HotelGuestbook.Classes.Reservation;
using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Apartment
{
    public static class ApartmentProvider
    {
        /// <summary>
        /// Returns all apartments in the database.
        /// </summary>
        public static IEnumerable<ApartmentInfo> GetAllApartments() => GuestBook.Context.Apartments;


        /// <summary>
        /// Returns an apartment by ID.
        /// </summary>
        /// <param name="id">ID of the apartment.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="id"/> is invalid.</exception>
        public static ApartmentInfo GetApartmentById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            return GuestBook.Context.Apartments.FirstOrDefault(apartment => apartment.ApartmentId == id);
        }


        /// <summary>
        /// Returns an apartment by number.
        /// </summary>
        /// <param name="number">Number of the apartment.</param>
        public static ApartmentInfo GetApartmentByRoomNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException(nameof(number));
            }

            return GuestBook.Context.Apartments.FirstOrDefault(apartment => apartment.Number == number);
        }


        /// <summary>
        /// Get all available apartments with the desired capacity and a given time frame.
        /// </summary>
        /// <param name="minimalCapacity">Minimum capacity of the apartments.</param>
        /// <param name="doubleBeds">Minimal number of double beds.</param>
        /// <param name="from">Beginning date.</param>
        /// <param name="to">Ending date.</param>
        public static IEnumerable<ApartmentInfo> GetAvailableApartments(int minimalCapacity, int doubleBeds, DateTime from, DateTime to)
        {
            var apartments = GetApartmentsWithCapacityAtLeast(minimalCapacity)
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

            return apartments.Except(occupiedApartments);
        }


        /// <summary>
        /// Returns all apartments with capacity greater than <paramref name="capaciy"/>.
        /// </summary>
        /// <param name="capaciy">The least desired capacity.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="capaciy"/> is invalid.</exception>
        public static IEnumerable<ApartmentInfo> GetApartmentsWithCapacityAtLeast(int capaciy)
        {
            if (capaciy <= 0)
            {
                throw new ArgumentException(nameof(capaciy));
            }

            return GuestBook.Context.Apartments.Where(apartment => apartment.Capacity >= capaciy);
        }


        /// <summary>
        /// Saves the <paramref name="apartment"/> to the database.
        /// </summary>
        /// <param name="apartment">Apartment to be saved.</param>
        /// <remarks>This method does nothing if <paramref name="apartment"/> is null.</remarks>
        public static void SetApartment(ApartmentInfo apartment)
        {
            if (apartment is null)
            {
                return;
            }

            GuestBook.Context.Apartments.Add(apartment);
            GuestBook.Context.SaveChanges();
        }


        /// <summary>
        /// Removes the <paramref name="apartment"/> from the database.
        /// </summary>
        /// <param name="apartment">Apartment to be removed.</param>
        /// <remarks>This method does nothing if <paramref name="apartment"/> is null.</remarks>
        public static void DeleteApartment(ApartmentInfo apartment)
        {
            if (apartment is null)
            {
                return;
            }

            GuestBook.Context.Apartments.Remove(apartment);
            GuestBook.Context.SaveChanges();
        }
    }
}
