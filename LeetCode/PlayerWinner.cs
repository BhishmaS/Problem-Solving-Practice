using System;
using System.Linq;

namespace Learning.LeetCode
{
    public class PlayerWinner
    {
        public PlayerWinner()
        {
        }

        public void FindWinner()
        {
            int[] numbers = { 1, 3, 3, 1, 5 };
            string winner = "Alice", player = "Bob";
            while (numbers.Length > 0)
            {
                player = player == "Bob" ? "Alice" : "Bob";
                if (numbers.Length == 1)
                {
                    Console.WriteLine(winner);
                }
                else
                {
                    bool pairFound = false;
                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        if (numbers[j] == numbers[j + 1])
                        {
                            pairFound = true;
                            numbers = numbers.Where((num, idx) => idx != j && idx != j + 1).ToArray();
                            break;
                        }
                    }

                    if (pairFound)
                    {
                        winner = player;
                    }
                    else
                    {
                        Console.WriteLine(winner);
                    }
                }
            }

            Console.WriteLine(winner);
        }
    }
}
