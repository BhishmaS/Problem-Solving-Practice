using System.Collections.Generic;

namespace Learning.DataStructures
{
    public class SortedSetDemo
    {
        public void Test()
        {
            var set = new SortedSet<int>();
            set.UnionWith(new SortedSet<int>());

            var first = set.Min;
            set.Remove(first);
            //var first1 = set[0];

            var set1 = new SortedSet<(int, int)>();
            var min = set1.Min;


            var set2 = new SortedSet<int> { 2 };
            int c = set2.Count;
        }
    }
}
