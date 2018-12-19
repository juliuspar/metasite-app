using System;

namespace MetasiteApp.Phones.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool Between(this DateTime actual, DateTime from, DateTime to) 
            => actual >= from && actual <= to;

        public static DateTime DefaultToMin(this DateTime? actual)
            => actual ?? DateTime.MinValue;

        public static DateTime DefaultToMax(this DateTime? actual)
            => actual ?? DateTime.MaxValue;
    }
}