using System;

namespace HotelGuestbook.Helpers
{
    /// <summary>
    /// Helper class for data and input conversion.
    /// </summary>
    public static class ConversionHelper
    {
        /// <summary>
        /// Converts the <paramref name="input"/> in format DD.MM.YYYY to DateTime.
        /// </summary>
        /// <param name="input">Input string that is being converted.</param>
        public static DateTime ConvertStringToDateTime(string input)
        {
            var dateParts = input.Split('.');

            return new DateTime(Convert.ToInt32(dateParts[2]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[0]));
        }
    }
}
