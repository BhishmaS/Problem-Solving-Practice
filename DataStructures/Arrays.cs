using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class ArraysDemo
    {
        static int[] array = new int[10];

        public static void Test()
        {
            array.Where(e => e == 10).ToArray();
            Array.Find(array, e => e == 10);
            Array.FindAll(array, e => e != 10);
            Array.FindIndex(array, a => a > 10);
            Array.IndexOf(array, 10);
            Array.ForEach(array, e =>
            { 

            });
            Array.Fill(array, -1);

            _ = array.Prepend(16);

            array.FirstOrDefault();
            array.SingleOrDefault();
            array.Select(e => e).ToArray();
            array.Take(5).ToArray();
            array.TakeWhile(e => e > 10);
            array
                .OrderBy(e => e)
                .ThenBy(e => e)
                .OrderByDescending(e => e)
                .ThenByDescending(e => e);

            array.Any(e => e > 10);
            array.All(e => e > 10);
            array.Min();
            array.ToList().GetRange(0, 20).Min();
            array.Sum();
            array.Count(a => a == -1);
            array.Aggregate(0, (sum, i) => sum + i);
            //Array.Copy();
            array.Except(array);
            var hashSet = array.ToHashSet();

            array.Select((e, i) => new { ele = e, index = i }).Where(a => a.ele == 10).Select(e => e.index).ToList();

            Array.IndexOf(array, 1);

            Array.Exists(array, element => element == 10);
            Array.Sort(array);
            Array.BinarySearch(array, 2);

            var res = array.Reverse();
            var newArray = array[12..20]; // >=12 && < 20


            var newArray1 = array[..20];
            int max = array.Max(a => a);
            int count = array.Count((a) => a == 0);

            _ = array['a'];
        }
    }

    public class ArrayClass2D
    {
        static void Print2DArray(int[,] arr)
        {
            Array.Sort(arr);
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }

            var copy = arr.Clone() as int[,];

            //arr.All();
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
            var fristIndexElems = arr.Select(a => a[0]).ToList();

            int[][] test = arr.Where(a => a[0] == 1).ToArray();
            int len = test.GetLength(0);
            if (test.Length > 0)
            {

            }

            foreach(var item in test)
            {

            }

            Array.Sort(arr);
            Array.Sort(arr, Comparer<int[]>.Create((x, y) => y[0] - x[0]));
            Array.Sort(arr, (a, b) => Comparer<int>.Create(Compare).Compare(a[0], b[0]));
            Array.Sort(arr, (a, b) => Comparer<int>.Create((x, y) => y - x).Compare(a[0], b[0]));
            Array.Sort(arr, (a, b) => b[1] - a[1]);
            arr = arr.OrderBy(a => a[0]).ThenBy(a => a[1]).ToArray();
            var arr1 = arr.Skip(1);
        }

        static int Compare(int x, int y)
        {
            return y - x;
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
