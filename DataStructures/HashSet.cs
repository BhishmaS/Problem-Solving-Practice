using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class HashSetDemo
    {
        public static void Test()
        {
            HashSet<int> evenNumbers = new HashSet<int> { 2, 6 };
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);

                oddNumbers.Add((i * 2) + 1);
            }

            DisplaySet(evenNumbers);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            numbers.UnionWith(oddNumbers);
            numbers.Contains(1);
            numbers.First(n => n == 1);
            //numbers.re
            //numbers.RemoveWhere();

            var newSet = evenNumbers.Except(oddNumbers);

            var intersection = evenNumbers.Intersect(oddNumbers);
            evenNumbers.IntersectWith(oddNumbers);

            var unoin = evenNumbers.Union(oddNumbers);
            evenNumbers.UnionWith(oddNumbers);

            var c = numbers.Count;

            numbers.Any(n => n > 2);

            DisplaySet(numbers);

            // Set Array
            var setArray = new HashSet<int>[9];

            var set = new HashSet<int>(9);
            var arr = set.OrderByDescending(s => s).ToArray();
            set.Clear();

            if (!set.Add(10))
            {
                var boolean = set.Add(10);
            }
        }

        public static void DisplaySet(HashSet<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

    }

    public class MyHashSet
    {
        int[] arr = new int[10];

        public bool Add(int x)
        {
            if (this.Contains(x))
                return false;

            int hashCode = x % 20;
            arr[hashCode] = x;

            return true;
        }

        public bool Contains(int x)
        {
            int hashCode = x % 20;

            return arr[hashCode] != 0;
        }

    }
}
