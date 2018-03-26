using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Classes.Person;
using HotelGuestbook.Classes.Reservation;
using NUnit.Framework;
using System.Linq;

namespace HotelGuestbook.Tests.TestsBase
{
    public class UnitTestsBase : DataInitializer
    {
        [SetUp]
        public void SetUp()
        {
            GenerateTestData();
        }


        [TearDown]
        public void TearDown()
        {
            Apartments = Enumerable.Empty<ApartmentInfo>().ToList();
            Persons = Enumerable.Empty<PersonInfo>().ToList();
            Reservations = Enumerable.Empty<ReservationInfo>().ToList();
        }
    }
}
