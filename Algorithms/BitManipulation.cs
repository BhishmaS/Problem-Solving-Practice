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
        }
    }
}
