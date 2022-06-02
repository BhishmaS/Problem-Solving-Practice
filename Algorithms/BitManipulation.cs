using System;

namespace Learning.Algorithms
{
    public class BitManipulation
    {
        public static void Test()
        {
            int x = 19;
            int leftShit = x << 1;
            int rightShift = x >> 1;

            int oddAnd = x & 1;
            int evenAnd = 18 & 1;
            int xor = 20 ^ 19 ^ 18 ^ 20 ^ 19; // 18 odd occurance

            string bitmask = Convert.ToString(2, 2).PadLeft(8, '0').PadRight(2, '1');
            int[] bits = decimal.GetBits(x);

            int num = 10;
            if ((num & 1) == 0) // even number
            {

            }
        }
    }
}
