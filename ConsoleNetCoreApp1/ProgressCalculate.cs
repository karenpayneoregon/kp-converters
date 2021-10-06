using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNetCoreApp1
{
    public static class ProgressCalculate
    {
        public static string PercentDone(this int Value, int Maximum)
        {
            int percent = (int)((Value / (Maximum - 1f)) * 100f);
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

    }
}
