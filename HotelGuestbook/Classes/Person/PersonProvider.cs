using System;
using System.Collections.Generic;

namespace HotelGuestbook.ExtensionMethods.Person
{
    public static class PersonProvider
    {
        /// <summary>
        /// Returns all parsons the account of whon is disabled.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllDisabledPersons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all editors.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllEditors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all parsons the account of whon is enabled.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllEnabledPersons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retuns all persons in the database.
        /// </summary>
        public static IEnumerable<PersonInfo> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a person by the specified email.
        /// </summary>
        /// <param name="email">Email of the person.</param>
        public static PersonInfo GetPersonByEmail(string email)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a person by their first name.
        /// </summary>
        /// <param name="firstName">First name of the person.</param>
        public static PersonInfo GetPersonByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a person by ID.
        /// </summary>
        /// <param name="id">ID of the person.</param>
        public static PersonInfo GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a person by their last name.
        /// </summary>
        /// <param name="lastName">Last name of the person.</param>
        public static PersonInfo GetPersonByLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
