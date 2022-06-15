using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    class SortedDictionaryDemo
    {
        public static void Test()
        {
            var sortedDictionary = new SortedDictionary<int, int>
            {
                { 1, 16 }
            };

            sortedDictionary.TryGetValue(1, out int value);
            sortedDictionary[1] += 1;

            sortedDictionary.Add(1, 16);

            value = sortedDictionary.First().Value;

            foreach (var item in sortedDictionary)
            {
                var key = item.Key;
                var itemValue = item.Value;
            }

            _ = sortedDictionary.Any(d => d.Value > 0);
        }
    }
}
