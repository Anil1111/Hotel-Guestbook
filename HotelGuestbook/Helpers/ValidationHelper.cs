using System;
using System.Net.Mail;

namespace HotelGuestbook.Helpers
{
    /// <summary>
    /// Helper class for validating inputs.
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Returns true if the person making the reservation is at least 18 years old.
        /// </summary>
        /// <param name="dateOfBirth">Date of birth of the person.</param>
        public static bool IsPersonAtLeastEighteen(DateTime dateOfBirth)
        {
            var age = GetAge(dateOfBirth);

            return !(age < 18);
        }


        /// <summary>
        /// Returns the age of the person from a specified birth date.
        /// </summary>
        /// <param name="birthDate">Person's date of birth.</param>
        private static int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }


        /// <summary>
        /// Returns true if the email is in valid format.
        /// </summary>
        /// <param name="email">Email to check.</param>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var unused = new MailAddress(email);
            }
            catch (Exception e)
            {
                if (e is ArgumentException || e is FormatException)
                {
                    return false;
                }

                throw;
            }

            return true;
        }


        /// <summary>
        /// Returns true if the name is valid.
        /// </summary>
        /// <param name="name">Name to check.</param>
        public static bool IsValidName(string name)
        {
            return !(string.IsNullOrEmpty(name));
        }
    }
}
