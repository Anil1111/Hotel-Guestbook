using HotelGuestbook.Classes.Person;
using HotelGuestbook.Tests.TestsBase;
using NUnit.Framework;
using System;
using System.Linq;

namespace HotelGuestbook.Tests.IntegrationTests
{
    public class PersonTests : IntegrationTestsBase
    {
        [Test]
        public void DataInitializer_GeneratesCorrectAmountOfPersons()
        {
            Assert.That(GuestBookContext.Persons.ToList().Count, Is.EqualTo(10));
        }


        [Test]
        public void SetPerson_PersonIsSavedToDb()
        {
            var person = new PersonInfo("First name", "Last name", "email@test.com", DateTime.Now);

            PersonProvider.SetPerson(person);

            Assert.That(GuestBookContext.Persons.ToList().Count, Is.EqualTo(11));
        }
    }
}
