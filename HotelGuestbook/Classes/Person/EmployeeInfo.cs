using System;
using HotelGuestbook.ExtensionMethods.Person;

namespace HotelGuestbook.Classes.Person
{
    public class EmployeeInfo : PersonInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstName">Employee's first name.</param>
        /// <param name="lastName">Employee's last name.</param>
        /// <param name="dateOfBirth">Employee's date of birth</param>
        /// <param name="email">Employee's email.</param>
        /// <param name="isEnabled">True if the employee is authorized to edit data.</param>
        public EmployeeInfo(string firstName, string lastName, DateTime dateOfBirth, string email, bool isEnabled = false)
            : base(firstName, lastName, dateOfBirth, email)
        {
            IsEnabled = isEnabled;
        }

        /// <summary>
        /// Is person enabled to allow editing data.
        /// </summary>
        public bool IsEnabled { get; set; }
    }
}
