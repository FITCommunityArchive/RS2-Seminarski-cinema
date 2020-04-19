using System;

namespace Cinema.Services.Helpers
{
    public static class TimeHelper
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
    }
}
