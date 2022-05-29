using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Utils
{
    class MathTest
    {
        public static void Test()
        {
            int rounded = (int)Math.Ceiling((double)12/5);

            double midK = (20 + 20) / 2;

            int pow = 2 ^ 4;

            int min = int.MinValue;

            long longMin = long.MinValue;

            int max = Math.Max(1, 2);

            int abs = Math.Abs(-1);

            double x = Math.Pow(2, 2);

            double round = Math.Round(2.9, 2, MidpointRounding.AwayFromZero);

            double.Parse("");
            double.TryParse("", out _);

            System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
            nfi.PercentDecimalDigits = 2;
        }
    }
}
