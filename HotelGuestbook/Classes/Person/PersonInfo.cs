using System;

namespace HotelGuestbook.Classes.Person
{
    public class PersonInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstName">Person's first name.</param>
        /// <param name="lastName">Person's last name.</param>
        /// <param name="dateOfBirth">Person's date of birth.</param>
        /// <param name="email">Person's email.</param>
        /// <param name="isEnabled">Indicates if person is enabled.</param>
        /// <param name="isEditor">True if a person has rights to edit reservations.</param>
        public PersonInfo(string firstName, string lastName, DateTime dateOfBirth, string email)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            DateOfBirth = dateOfBirth;
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Person ID.
        /// </summary>
        int PersonId { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// E-mail.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        DateTime DateOfBirth { get; set; }
    }
}
