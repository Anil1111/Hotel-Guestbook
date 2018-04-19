using HotelGuestbook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelGuestbook.Classes.Person
{
    public static class PersonProvider
    {
        public const string ANONYMIZED_STRING = @"**********";


        /// <summary>
        /// Returns all persons in the database.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllPersons() => GuestBook.Context.Persons;


        /// <summary>
        /// Returns a person by ID.
        /// </summary>
        /// <param name="id">ID of the person.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="id"/> is invalid.</exception>
        public static PersonInfo GetPersonById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            return GuestBook.Context.Persons.FirstOrDefault(person => person.PersonId == id);
        }


        /// <summary>
        /// Returns a person by their first name.
        /// </summary>
        /// <param name="firstName">First name of the person.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="firstName"/> is null or empty.</exception>
        public static IEnumerable<PersonInfo> GetPersonsByFirstName(string firstName)
        {
            if (String.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException(nameof(firstName));
            }

            return GuestBook.Context.Persons.Where(person => person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Returns a person by their last name.
        /// </summary>
        /// <param name="lastName">Last name of the person.</param>
        /// /// <exception cref="ArgumentException">Thrown when <paramref name="lastName"/> is null or empty.</exception>
        public static IEnumerable<PersonInfo> GetPersonsByLastName(string lastName)
        {
            if (String.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException(nameof(lastName));
            }

            return GuestBook.Context.Persons.Where(person => person.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Returns a person by the specified email.
        /// </summary>
        /// <param name="email">Email of the person.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="email"/> is null or empty.</exception>
        public static PersonInfo GetPersonByEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException(nameof(email));
            }

            return GuestBook.Context.Persons.FirstOrDefault(person => person.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }


        /// <summary>
        /// Saves the <paramref name="person"/> to the database.
        /// </summary>
        /// <param name="person">Person to be saved.</param>
        /// <remarks>The method does nothing if <paramref name="person"/> is null.</remarks>
        public static void SetPerson(PersonInfo person)
        {
            if (person is null)
            {
                return;
            }

            if (GetPersonByEmail(person.Email) == null)
            {
                GuestBook.Context.Persons.Add(person);
                GuestBook.Context.SaveChanges();
            }
        }


        /// <summary>
        /// Deletes the <paramref name="person"/> from the database.
        /// </summary>
        /// <param name="person">Person to be deleted.</param>
        /// <remarks>The method does nothing if <paramref name="person"/> is null.</remarks>
        public static void DeletePerson(PersonInfo person)
        {
            if (person is null)
            {
                return;
            }

            GuestBook.Context.Persons.Remove(person);
            GuestBook.Context.SaveChanges();
        }

        public static void AnonymizePerson(PersonInfo person)
        {
            person.FirstName = ANONYMIZED_STRING;
            person.LastName = ANONYMIZED_STRING;
            person.Email = ANONYMIZED_STRING;
            person.DateOfBirth = new DateTime(9999, 1, 1);
            person.Anonymized = true;

            GuestBook.Context.SaveChanges();
        }
    }
}
