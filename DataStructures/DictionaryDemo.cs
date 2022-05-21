using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class DictionaryDemo
    {
        public static void Test()
        {

            var dict1 = new Dictionary<int, int>
            {
                { 1, 1 }
            };

            var dict = new Dictionary<int, int>();
            dict.Add(1, 1);
            dict.OrderBy(d => d.Key);

            dict.Select(d => d.Value).ToList();

            var value = dict[1];

            dict.TryGetValue(1, out value);

            dict.ContainsKey(1);
            dict.ContainsValue(2);
            dict.Remove(1);
            dict.All(d => d.Value == 0);

            int x = dict[1]++;

            dict.Sum(d => d.Value);
            var dictItem = dict.SingleOrDefault(d => d.Value != 0);
            var k = dictItem.Key;

            int maxVal = dict.Max(d => d.Value);

            dict.OrderBy(d => d.Key).ThenBy(d => d.Value).Take(3).Select(d => d.Key);

            ////---------------------------------------------------------

            var sortedDictionary = new SortedDictionary<int, int>();
            sortedDictionary.Add(1, 16);

            sortedDictionary.TryGetValue(1, out value);
            sortedDictionary[1] += 1;

            value = sortedDictionary.First().Value;

            foreach (var item in sortedDictionary)
            {
                var key = item.Key;
                var itemValue = item.Value;
            }

            sortedDictionary.Any(d => d.Value > 0);

            ////--------------------------------------------------------- Key Value Pair
            var keyValue = new KeyValuePair<int, int>(1, 2);
            //keyValue.Key = 0; read onlyyyyyyyyyyyyyy

        }

        public static IList<IList<int>> VerticalTraversal()
        {
            var resultDict = new Dictionary<int, Dictionary<int, int>>();
            var resultList = resultDict.OrderBy(r => r.Key)
                    .Select(r => (IList<int>)r.Value.Select(d => d.Value).ToList())
                    .ToList();

            return resultList;
        }
    }
}
