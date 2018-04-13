using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HotelGuestbook.Helpers
{
    /// <summary>
    /// Helper class for validating inputs.
    /// </summary>
    public static class ValidationHelper
    {
        public static bool IsPersonAtLeastEighteen(DateTime dateOfBirth)
        {
            var age = GetAge(dateOfBirth);

            return !(age < 18);
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                new MailAddress(email);
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

        public static bool IsValidLastName(string lastName)
        {
            return !(String.IsNullOrEmpty(lastName));
        }

        public static bool IsValidFirstName(string firstName)
        {
            return !(String.IsNullOrEmpty(firstName)) ;
        }

        private static int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;

            if (bornDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
