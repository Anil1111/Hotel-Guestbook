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
        [Ignore("Depends on current DB state")]
        public void DataInitializer_GeneratesCorrectAmountOfPersons()
        {
            Assert.That(GuestBookContext.Persons.ToList().Count, Is.EqualTo(10));
        }

        
        [Test]
        public void GetAllPersons_ReturnsAllPersons()
        {
            var count = GuestBookContext.Persons.Count();

            Assert.That(PersonProvider.GetAllPersons().Count(), Is.EqualTo(count));
        }


        [Test]
        public void GetPersonByFirstName_ReturnsCorrectPerson()
        {
            var persons = PersonProvider.GetPersonsByFirstName("Irene").ToList();

            Assert.That(persons.Count, Is.EqualTo(1));
        }


        [Test]
        public void GetPersonByLastName_ReturnsCorrectPerson()
        {
            var persons = PersonProvider.GetPersonsByLastName("Kennedy").ToList();

            Assert.That(persons.First().FirstName, Is.EqualTo("Kimberly"));
        }


        [Test]
        public void GetPersonByEmail_ReturnsCorrectPerson()
        {
            var person = PersonProvider.GetPersonByEmail("doughertya@mail.com");

            Assert.That(person.FirstName, Is.EqualTo("Aria"));
        }


        [Test]
        public void SetPerson_PersonIsSavedToDb()
        {
            var person = new PersonInfo("First name", "Last name", "email@test.com", DateTime.Now);
            var count = GuestBookContext.Persons.ToList().Count;

            PersonProvider.SetPerson(person);

            Assert.That(PersonProvider.GetAllPersons().Count(), Is.EqualTo(count + 1));
        }


        [Test]
        public void DeletePerson_PersonIsDeletedFromDb()
        {
            var person = PersonProvider.GetAllPersons().First();
            var count = GuestBookContext.Persons.ToList().Count;

            PersonProvider.DeletePerson(person);

            Assert.That(PersonProvider.GetAllPersons().Count(), Is.EqualTo(count - 1));
        }
    }
}
