using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class ListDemo
    {
        static readonly List<int> list = new();

        public static void Test()
        {
            var ele = list[1];
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
            list.IndexOf(1);
            list.Remove(1);
            list.RemoveAt(1);
            list.Reverse(); // returns void
            list.Add(1); // void
            list.RemoveAt(list.Count - 1);

            list.Min();
            list.Min(l => l < 2);
            list.Find(l => l < 2);
            list.ForEach(l =>
            {

            });
            //list.Join(list);

            // Replace item in list
            int index = list.FindIndex(l => l == 2);
            if (index != -1)
                list[index] = 10;

            list.Sort((a, b) => b - a);
            list.OrderByDescending(a => a);
            list.RemoveAt(list.Count - 1);

            foreach (var i in list.Where(i => i == 10))
            {

            }

            var list2 = new List<int>(list);
            var list3 = new List<int>(3);

            var listOfList = new List<List<int>>();
            listOfList = listOfList.Concat(new List<List<int>>()).ToList();

            var stringList = new List<string>();
            stringList.Sort(StringComparer.Ordinal);

            //SortedList
            var list4 = new List<(int x, int y)>(3);
            int x = list4[0].x;
            int y = list4[0].y;
        }

        private static int Compare(int x, int y)
        {
            return y - x;
        }

        public static IList<IList<int>> ListReturn()
        {
            return new List<IList<int>>();
        }
    }
}
