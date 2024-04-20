using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Backend.Services
{
    public static class ParsingService
    {
        public static string ParseStartTime(string startTime)
        {
            if(!string.IsNullOrEmpty(startTime) && startTime.Length >= 16)
            {
                return startTime.Substring(11, 5);
            }
            throw new ArgumentException("Bad date format");
        }

        public static string ParseStartDate(string startTime)
        {
            if (!string.IsNullOrEmpty(startTime) && startTime.Length >= 10)
            {
                return startTime.Substring(0, 10);
            }

            throw new ArgumentException("Bad date format");
        }

        public static DateTime ParseStringToDateTime(string dateString)
        {
            DateTime parsedDate;
            if(DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate;
            }

            throw new ArgumentException("Bad date format");
        }

        public static DateTime ParseStringToDateTimeWithTime(string dateString)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate;
            }

            throw new ArgumentException("Bad date format");
        }
    }
}
