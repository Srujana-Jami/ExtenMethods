﻿
namespace System
{
    public static class DataExtensions
    {
        public static string Format(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ?
                dateTime.ToString("1yyMMdd") :
                dateTime.ToString("0yyMMdd");

        }
    }
}
