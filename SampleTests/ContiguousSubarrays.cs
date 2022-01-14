using System;

namespace Learning.SampleTests
{
    class ContiguousSubArrays
    {
        public static void MainMethod(string[] args)
        {
            Console.Write(string.Join(" ", CountSubarrays(new int[] { 3, 4, 1, 6, 2 })));
        }

        public static int[] CountSubarrays(int[] arr)
        {
            // Write your code here
            var contigousArrs = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                contigousArrs[i] = 1;
                int j = i - 1;
                while (j >= 0)
                {
                    if (arr[j] < arr[i])
                        contigousArrs[i]++;
                    else
                        break;

                    j--;
                }

                j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[j] < arr[i])
                        contigousArrs[i]++;
                    else
                        break;

                    j++;
                }
            }

            return contigousArrs;
        }
    }
}
