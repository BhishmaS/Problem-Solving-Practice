using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class Dictionary
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
            

            var nodes = new List<int>();
            nodes.Sort();


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
        }

        public IList<IList<int>> VerticalTraversal()
        {
            var resultDict = new Dictionary<int, Dictionary<int, int>>();
            var resultList = resultDict.OrderBy(r => r.Key)
                    .Select(r => (IList<int>)r.Value.Select(d => d.Value).ToList())
                    .ToList();

            return resultList;
        }
    }
}
