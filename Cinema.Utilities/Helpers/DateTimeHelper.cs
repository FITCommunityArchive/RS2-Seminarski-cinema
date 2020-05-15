using System;

namespace Cinema.Utilities.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime GenerateFutureTime(int additionalMonthsLimit = 0, int additionalDaysLimit = 0, int lowerHourOfDayLimit = 0, int upperHourOfDayLimit = 0, int additionalMinutesLimit = 0)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            Random random = new Random();

            dateTime = dateTime.AddMonths(random.Next(additionalMonthsLimit));
            dateTime = dateTime.AddDays(random.Next(additionalDaysLimit));
            dateTime = dateTime.AddHours(random.Next(lowerHourOfDayLimit, upperHourOfDayLimit));
            dateTime = dateTime.AddMinutes(random.Next(additionalMinutesLimit));

            return dateTime;
        }

        public static string ToFormattedDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd.MM.yyyy");
        }

        public static string ToFormattedTime(this DateTime dateTime)
        {
            return dateTime.ToString("t");
        }

        public static DateTime ToDate(this string source)
        {
            if (source == null) return DateTime.MinValue;
            return DateTime.Parse(source);
        }
    }
}
