using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelGuestbook.Classes.Person
{
    [Table("Persons")]
    public class PersonInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstName">Person's first name.</param>
        /// <param name="lastName">Person's last name.</param>
        /// <param name="email">Person's email.</param>
        /// <param name="dateOfBirth">Person's date of birth.</param>
        public PersonInfo(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            DateOfBirth = dateOfBirth;
        }

        protected PersonInfo() { }

        /// <summary>
        /// Person ID.
        /// </summary>
        [Key]
        public int PersonId { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// E-mail.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
