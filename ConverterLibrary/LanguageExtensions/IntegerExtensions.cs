using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.LanguageExtensions
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Flip negative to positive or positive to negative
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int Invert(this int source) =>
            source * (-1);

        /// <summary>
        /// Determine if value is positive
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>true if positive or false if not</returns>
        public static bool IsPositive(this int sender) 
            => sender > 0;

        /// <summary>
        /// Determine if value is negative
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>true of negative otherwise false</returns>
        public static bool IsNegative(this int sender) 
            => sender < 0;


        /// <summary>
        /// Convert int to decimal e.g. 25 will return .25
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static decimal IntToDecimal(this int sender) => (decimal)sender / 100;

        /// <summary>
        /// Convert int to Yes/No
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Yes or No as a string</returns>
        public static string ToYesNoFormat(this int sender) => Convert.ToBoolean(sender) ? "Yes" : "No";

        /// <summary>
        /// Formats an int as Yes/No
        /// </summary>
        /// <param name="sender">int value of 0 or 1</param>
        /// <returns></returns>
        /// <remarks>Throw <see cref="InvalidOperationException"/> if int is not 0 or 1</remarks>
        public static string ToYesNo(this int sender) => sender switch
        {
            0 => "No",
            1 => "Yes",
            _ => throw new InvalidOperationException($"Integer value {sender} is not valid")
        };

        /// <summary>
        /// Provide percent completed
        /// </summary>
        /// <param name="value">Current position</param>
        /// <param name="maximum">Total to calculate against</param>
        /// <returns>Empty string for percent less than one percent otherwise current position as a percent</returns>
        /// <remarks>
        /// Code from ProgressODoom.AbstractProgressBar and modified to work standalone
        /// </remarks>
        public static string PercentDone(this int value, int maximum)
        {

            if (value < 0) { throw new ArgumentException("Value must be greater than or equal to minimum."); }
            if (value > maximum) { throw new ArgumentException("Value must be less than or equal to maximum."); }

            int percent = (int)((value / (maximum - 1f)) * 100f);
            if (percent > 0)
            {
                if (percent > 100) { percent = 100; }
                return $"{percent}%";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Convert a string to a Nullable int or null
        /// </summary>
        /// <param name="value">value to attempt a convert to int on</param>
        /// <returns>Nullable int or null</returns>
        public static int? ToNullableInt(this string value) 
            => int.TryParse(value, out var result) ? result : null;
    }
}
