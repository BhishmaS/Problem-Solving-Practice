using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.SampleTests
{
    class Sample
    {
        //// (1) ############################################################################
        
        public static string[] isWordPresent(char[,] letters, string[] words)
		{
			string[] answer = new string[100];
			var totalWords = new List<string>();

			for (int i = 0; i < letters.GetLength(0); i++)
			{
				string word = string.Empty;
				for (int j = 0; j < letters.GetLength(1); j++)
				{
					word = word + letters[i, j].ToString();
				}

				totalWords.Add(word);
			}

			for (int i = 0; i < letters.GetLength(1); i++)
			{
				string word = string.Empty;
				for (int j = 0; j < letters.GetLength(0); j++)
				{
					word = word + letters[j, i].ToString();
				}

				totalWords.Add(word);
			}

			answer = words.Select(word =>
			{
				bool doesAnyWordMatch = totalWords.Any(fw =>
				{
					return fw.Contains(word) || string.Join("", fw.Reverse().ToArray()).Contains(word);
				});

				return doesAnyWordMatch ? "Yes" : "No";
			}).ToArray();

			return answer;
        }

        //// (2) ############################################################################

        static int[][] Solution(int[][] bubbles)
        {
            int[][] newBubbles = new int[bubbles.Length][];
            for (int i = 0; i < bubbles.Length; i++)
            {
                newBubbles[i] = new int[bubbles[0].Length];
            }

            for (int i = 0; i < bubbles.Length; i++)
            {
                for (int j = 0; j < bubbles[i].Length; j++)
                {
                    if (bubbles[i][j] != 0)
                    {
                        int neighboursCount = 0;
                        if (j - 1 >= 0 && bubbles[i][j] == bubbles[i][j - 1])
                            neighboursCount++;

                        if (j + 1 < bubbles[0].Length && bubbles[i][j] == bubbles[i][j + 1])
                            neighboursCount++;

                        if (i - 1 >= 0 && bubbles[i][j] == bubbles[i - 1][j])
                            neighboursCount++;

                        if (i + 1 < bubbles.Length && bubbles[i][j] == bubbles[i + 1][j])
                            neighboursCount++;

                        if (neighboursCount >= 2)
                        {
                            DFS(bubbles, i, j);
                        }
                    }
                }
            }

            for (int j = 0; j < bubbles[0].Length; j++)
            {
                var set = new SortedSet<int>();
                for (int i = bubbles.Length - 1; i >= 0; i--)
                {
                    if (bubbles[i][j] == 0)
                    {
                        set.Add(i);
                    }
                    else
                    {
                        if (set.Count > 0)
                        {
                            var maxIndex = set.Max;
                            bubbles[maxIndex][j] = bubbles[i][j];
                            bubbles[i][j] = 0;
                            set.Remove(maxIndex);
                            set.Add(i);
                        }
                    }
                }
            }

            return bubbles;
        }
        private static void DFS(int[][] bubbles, int i, int j)
        {
            if (i < 0 || i >= bubbles.Length || j < 0 || j >= bubbles[0].Length)
                return;

            int currValue = bubbles[i][j];
            bubbles[i][j] = 0;
            if (j - 1 >= 0 && currValue == bubbles[i][j - 1])
                DFS(bubbles, i, j - 1);

            if (j + 1 < bubbles[0].Length && currValue == bubbles[i][j + 1])
                DFS(bubbles, i, j + 1);

            if (i - 1 >= 0 && currValue == bubbles[i - 1][j])
                DFS(bubbles, i - 1, j);

            if (i + 1 < bubbles.Length && currValue == bubbles[i + 1][j])
                DFS(bubbles, i + 1, j);
        }

        //// (Main) ############################################################################

        public static void MainMethod(string[] args)
		{
            //// (1) ############################################################################
            
            string[] input;
			//input for letters
			input = Console.ReadLine().Split(' ');
			int letters_row = int.Parse(input[0]);
			int letters_col = int.Parse(input[1]);
			char[,] letters = new char[letters_row, letters_col];
			for (int idx = 0; idx < letters_row; idx++)
			{
				input = Console.ReadLine().Split(' ');
				for (int jdx = 0; jdx < letters_col; jdx++)
				{
					letters[idx, jdx] = char.Parse(input[jdx]);
				}
			}

			//input for words
			int words_size = int.Parse(Console.ReadLine());
			string[] words = new string[words_size];
			input = Console.ReadLine().Split(' ');
			for (int idx = 0; idx < words_size; idx++)
			{
				words[idx] = (input[idx]);
			}


			string[] result = isWordPresent(letters, words);
			for (int idx = 0; idx < result.Length - 1; idx++)
			{
				Console.Write(result[idx] + " ");
			}
			Console.Write(result[result.Length - 1]);

            //// (2) ############################################################################

            int[][] bubbles = new int[4][];
            bubbles[0] = new int[] { 3, 1, 2, 7 };
            bubbles[1] = new int[] { 1, 1, 1, 10 };
            bubbles[2] = new int[] { 2, 1, 9, 9 };
            bubbles[3] = new int[] { 2, 2, 9, 11 };

            Solution(bubbles);

            //// ############################################################################
        }
    }
}
