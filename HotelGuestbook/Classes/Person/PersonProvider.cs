using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Person
{
    public static class PersonProvider
    {
        /// <summary>
        /// Returns all persons in the database.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllPersons() => GuestBook.Context.Persons;


        /// <summary>
        /// Returns a person by ID.
        /// </summary>
        /// <param name="id">ID of the person.</param>
        public static PersonInfo GetPersonById(int id) => GuestBook.Context.Persons.FirstOrDefault(person => person.PersonId == id);


        /// <summary>
        /// Returns a person by their first name.
        /// </summary>
        /// <param name="firstName">First name of the person.</param>
        public static IEnumerable<PersonInfo> GetPersonsByFirstName(string firstName)
        {
            return GuestBook.Context.Persons.Where(person => person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Returns a person by their last name.
        /// </summary>
        /// <param name="lastName">Last name of the person.</param>
        public static IEnumerable<PersonInfo> GetPersonsByLastName(string lastName)
        {
            return GuestBook.Context.Persons.Where(person => person.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Returns a person by the specified email.
        /// </summary>
        /// <param name="email">Email of the person.</param>
        public static PersonInfo GetPersonByEmail(string email)
        {
            return GuestBook.Context.Persons.FirstOrDefault(person => person.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Saves the <paramref name="person"/> to the database.
        /// </summary>
        /// <param name="person">Person to be saved.</param>
        public static void SetPerson(PersonInfo person)
        {
            GuestBook.Context.Persons.Add(person);
            GuestBook.Context.SaveChanges();
        }
    }
}
