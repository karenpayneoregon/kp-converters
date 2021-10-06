using System;

namespace ConverterLibrary.LanguageExtensions
{
    /// <summary>
    /// Extensions that are method vs function based.
    /// 
    /// </summary>
    public static class TryParseExtensions
    {
        public static int TryParseInt32(this string value) => TryParse<int>(value, int.TryParse);

        public static short TryParseInt16(this string value) => TryParse<short>(value, short.TryParse);

        public static long TryParseInt64(this string value) => TryParse<long>(value, long.TryParse);

        public static byte TryParseByte(this string value) => TryParse<byte>(value, byte.TryParse);

        public static bool TryParseBoolean(this string value) => TryParse<bool>(value, bool.TryParse);
        public static double TryParseDouble(this string value) => TryParse<double>(value, double.TryParse);

        public static decimal TryParseDecimal(this string value) => TryParse<decimal>(value, decimal.TryParse);

        public static DateTime TryParseDateTime(this string value) => TryParse<DateTime>(value, DateTime.TryParse);

        #region Private generic
        private delegate bool ParseDelegate<T>(string s, out T result);

        private static T TryParse<T>(this string value, ParseDelegate<T> parse) where T : struct
        {
            parse(value, out var result);
            return result;
        }
        #endregion

    }
}