using System;
using System.Collections.Generic;

namespace HotelGuestbook.ExtensionMethods.Apartment
{
    public static class ApartmentProvider
    {
        /// <summary>
        /// Returns an apartment by ID.
        /// </summary>
        /// <param name="id">ID of the apartment.</param>
        public static ApartmentInfo GetApartmentById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all apartments with capacity greater than <paramref name="capaciy"/>.
        /// </summary>
        /// <param name="capaciy">The least desired capacity.</param>
        public static IEnumerable<ApartmentInfo> GetApartmentsWithCapacityGraterThan(int capaciy)
        {
            throw new NotImplementedException();
        }
    }
}
