using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Apartment
{
    public static class ApartmentProvider
    {
        /// <summary>
        /// Returns an apartment by ID.
        /// </summary>
        /// <param name="id">ID of the apartment.</param>
        public static ApartmentInfo GetApartmentById(int id)
        {
            return GuestBook.Context.Apartments.FirstOrDefault(apartment => apartment.ApartmentId == id);
        }

    
        /// <summary>
        /// Returns all apartments with capacity greater than <paramref name="capaciy"/>.
        /// </summary>
        /// <param name="capaciy">The least desired capacity.</param>
        public static IEnumerable<ApartmentInfo> GetApartmentsWithCapacityAtLeast(int capaciy)
        {
            return GuestBook.Context.Apartments.Where(apartment => apartment.Capacity >= capaciy);
        }


        /// <summary>
        /// Saves the <paramref name="apartment"/> to the database.
        /// </summary>
        /// <param name="apartment">Apartment to be saved.</param>
        public static void SetApartment(ApartmentInfo apartment)
        {
            GuestBook.Context.Apartments.Add(apartment);
            GuestBook.Context.SaveChanges();
        }
    }
}
