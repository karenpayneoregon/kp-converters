using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary.LanguageExtensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Calculates percentage of a number
        /// </summary>
        /// <param name="total">Total value</param>
        /// <param name="percentDone">Percent of <see cref="total"/></param>
        /// <returns>Percent of <see cref="total"/></returns>
        public static double PercentOf(this double total, double percentDone) 
            => (percentDone / 100.0) * total;

    }
}
