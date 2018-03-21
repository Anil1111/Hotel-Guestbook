using HotelGuestbook.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGuestbook.Tests.IntegrationTests
{
    public class IntegrationTests : DataInitializer
    {
        private GuestBookContext guestBookContext;

        [SetUp]
        public void SetUp()
        {
            guestBookContext = new GuestBookContext();
            base.Seed(guestBookContext);
        }


        [Test]
        public void Test()
        {
            var persons = guestBookContext.Guests.ToList();

            Assert.That(persons.Count, Is.EqualTo(1));
        }
    }
}
