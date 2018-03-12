using System;
using System.Collections.Generic;

namespace HotelGuestbook.Classes.Person
{
    public class GuestInfo : PersonInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstName">Guest's first name.</param>
        /// <param name="lastName">Guest's last name.</param>
        /// <param name="dateOfBirth">Guest's date of birth.</param>
        /// <param name="email">Guest's email.</param>
        public GuestInfo(string firstName, string lastName, DateTime dateOfBirth, string email)
            : base(firstName, lastName, dateOfBirth, email) { }

        /// <summary>
        /// Collection of Guests.
        /// </summary>
        public virtual ICollection<GuestInfo> Guests { get; set; }
    }
}
