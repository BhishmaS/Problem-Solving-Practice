using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.SampleTests
{
    class Cisco
    {
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

		public static void MainMethod(string[] args)
		{
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
		}
	}
}
