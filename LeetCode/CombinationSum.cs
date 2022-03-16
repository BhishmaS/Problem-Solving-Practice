using System.Collections.Generic;
using System.Linq;

namespace Learning.LeetCode
{
    public class CombinationSum
    {
        public IList<IList<int>> FindCombinationSum(int[] candidates, int target)
        {
            var list = this.Combinations(candidates, 0, new List<int>(), target);
            return list;
        }

        private IList<IList<int>> Combinations(
            int[] candidates,
            int currIdx,
            List<int> currCombination,
            int target)
        {
            var validCombinations = new List<IList<int>>();
            if (currCombination.Sum() >= target)
            {
                if (currCombination.Sum() == target)
                {
                    validCombinations.Add(currCombination.ToList());
                }

                return validCombinations;
            }

            for (int i = currIdx; i < candidates.Length; i++)
            {
                currCombination.Add(candidates[i]);
                var newValidCombi = this.Combinations(candidates, i, currCombination, target);
                validCombinations = validCombinations.Concat(newValidCombi).ToList();

                currCombination.RemoveAt(currCombination.Count - 1);
            }

            return validCombinations;
        }
    }
}
