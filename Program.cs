using Learning.DataStructures;
using System;
using System.Linq;

namespace Learning
{
    class Program
	{
		public static void Main(string[] args)
		{
            string s = "eceba";
            int k = 2;
            int[] chars = new int[26];
            int maxLen = 0, maxChars = 0, left = 0;

            for (int i = 0; i < s.Length; i++)
            {
                maxChars = Math.Max(maxChars, ++chars[s[i] - 'A']);

                if (i - left + 1 - maxChars > k)
                {
                    chars[s[left++] - 'A']--;
                }

                maxLen = Math.Max(maxLen, i - left + 1);
            }

            Console.WriteLine(maxLen);
        }
	}
}
