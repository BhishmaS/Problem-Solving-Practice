using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class Arrays
    {
        int[] array = new int[10];
        List<int> list = new();

        public void Test()
        {
            array.Where(e => e == 10).ToArray();
            Array.Find(array, e => e == 10);
            Array.FindAll(array, e => e != 10);
            Array.ForEach(array, e =>
            { 

            });
            array.Prepend(16);

            array.FirstOrDefault();
            array.SingleOrDefault();
            array.Select(e => e).ToArray();
            array.Take(5).ToArray();
            array.TakeWhile(e => e > 10);
            array.OrderBy(e => e).ThenBy(e => e)
                .OrderByDescending(e => e).ThenByDescending(e => e);
            array.Any(e => e > 10);
            array.All(e => e > 10);
            array.Min();
            array.ToList().GetRange(0, 20).Min();

            Array.Exists(array, element => element == 10);
            Array.Sort(array);

            int max = array.Max(a => a);

            list.Insert(0, 1);
            list.Find(e => e == 10);
            list.FindAll(e => e == 10);
            list.Select(e =>
            {
                return new { e };
            });
            list.FirstOrDefault();
            list.SingleOrDefault();
            list.Select(e => e).ToList();
            list.TakeWhile(e => e > 10);
            list.RemoveRange(0, 10);
            list.Sum();

            list.Min();
            //SortedList
        }
    }

    public class ArrayClass2D
    {
        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void PrintJaggedArray(int[][] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i][j]);
                }
            }

            int max = arr.Max(a => a[2]);
            arr.Any(a => a[0] == 1);
            arr.SingleOrDefault(a => a[0] == 1);
            int[][] test = arr.Where(a => a[0] == 1).ToArray();
            if (test.Length > 0)
            {

            }

            foreach(var item in test)
            {

            }
        }

        static void MainTest()
        {
            // Pass the array as an argument.
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
