using System;

namespace ExtenMethods.Contracts
{
    public static class DataExtensions
    {
        private static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
        public static long ToUnixSeconds(this DateTime dateTime)
        {
            var totalSeconds = (dateTime.ToUniversalTime() - EPOCH).TotalSeconds;
            return (long)Math.Round(totalSeconds, 0);
        }
    }
}
