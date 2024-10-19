using System;

namespace Learning.Algorithms
{
    class DynamicProgrammingDemo
    {
        public static void Test()
        {
        }
    }

    class ZeroByOneKnapsack
    {

    }

    class UnboundedKnapsack
    {

    }

    class LongestCommonSubsequenceDemo
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            return dp[text1.Length, text2.Length];
        }

        public int LongestCommonSubsequence_BU(string text1, string text2)
        {
            int?[,] memo = new int?[text1.Length + 1, text2.Length + 1];

            return this.LCSSimulator(text1, text2, memo);
        }

        private int LCSSimulator(string text1, string text2, int?[,] memo, int m = 0, int n = 0)
        {
            if (m == text1.Length || n == text2.Length)
                return 0;

            if (memo[m, n] != null)
                return (int)memo[m, n];

            if (text1[m] == text2[n])
            {
                memo[m, n] = 1 + this.LCSSimulator(text1, text2, memo, m + 1, n + 1);
            }
            else
            {
                memo[m, n] = Math.Max(
                    this.LCSSimulator(text1, text2, memo, m + 1, n),
                    this.LCSSimulator(text1, text2, memo, m, n + 1)
                );
            }

            return (int)memo[m, n];
        }
    }

    class LongestIncreasingSubsequence
    {

    }

    class MatrixChainMultiplication
    {

    }

    class DPOnGrids
    {

    }
}
