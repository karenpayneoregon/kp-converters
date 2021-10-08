using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.LanguageExtensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Get major and fraction parts of a double
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>named value tuple of int,decimal</returns>
        public static (int major, decimal fraction) GetParts(this double sender)
        {
            decimal fraction = (decimal)sender;
            int majorPart = (int)fraction;
            decimal decimalPart = fraction % 1.0m;

            return (majorPart, decimalPart);
        }

        public static int GetMajor(this decimal sender)
            => (int)sender;

        /// <summary>
        /// Count decimal places in a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static decimal CountDecimalPlaces(this decimal sender)
        {

            int[] bits = decimal.GetBits(sender);
            ulong lowInt = (uint)bits[0];
            ulong midInt = (uint)bits[1];
            int exponent = (bits[3] & 0x00FF0000) >> 16;
            int result = exponent;
            ulong lowDecimal = lowInt | (midInt << 32);

            while (result > 0 && (lowDecimal % 10) == 0)
            {
                result--;
                lowDecimal /= 10;
            }

            return result;
        }

        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private static string Fixer(this decimal sender) => sender % 1 == 0 ? $"{sender:C0}" : $"{sender:C2}";

        /// <summary>
        /// Flip negative to positive or positive to negative
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static decimal Invert(this decimal source) =>
            source * (-1);
    }
}
