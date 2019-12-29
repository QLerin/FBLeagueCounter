using System;

namespace FBLeagueTimer.Utilities
{
    public static class DateTimeToUnixTimeStamp
    {
        public static string UnixTimeStamp(this DateTime dateTime)
        {
            return dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds.ToString();
        }
    }
}
