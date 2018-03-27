using HotelGuestbook.Classes.Apartment;
using HotelGuestbook.Tests.TestsBase;
using NUnit.Framework;
using System.Linq;

namespace HotelGuestbook.Tests.IntegrationTests
{
    public class ApartmentTests : IntegrationTestsBase
    {
        [Test]
        public void DataInitializer_GeneratesCorrectAmountOfApartments()
        {
            Assert.That(GuestBookContext.Apartments.ToList().Count, Is.EqualTo(10));
        }


        [Test]
        public void GetAllApartments_ReturnsAllApartments()
        {
            var count = GuestBookContext.Apartments.Count();

            Assert.That(ApartmentProvider.GetAllApartments().Count(), Is.EqualTo(count));
        }


        [Test]
        public void GetApartmentsWithCapacityAtLeast_ReturnsCorrectNumberOfApartments()
        {
            var count = ApartmentProvider.GetApartmentsWithCapacityAtLeast(4).Count();

            Assert.That(count, Is.EqualTo(3));
        }
    }
}
