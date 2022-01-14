using System.Collections.Generic;
using System.Linq;

namespace Learning.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var resultDict = new Dictionary<int, Dictionary<int, List<int>>>();

            resultDict = this.Traverse(root, 0, 0, resultDict);
            var resultList = resultDict.OrderBy(r => r.Key)
                        .Select(r => 
                        {
                            return (IList<int>)r.Value
                                .OrderBy(v => v.Key)
                                .SelectMany(d => d.Value).ToList();
                        })
                        .ToList();

            return resultList;
        }

        public Dictionary<int, Dictionary<int, List<int>>> Traverse(
            TreeNode node, int row, int col,
            Dictionary<int, Dictionary<int, List<int>>> result)
        {

            if (node != null)
            {
                var nodes = new Dictionary<int, List<int>>();
                if (result.TryGetValue(col, out nodes))
                {
                    var rowNodes = new List<int>();
                    if (nodes.TryGetValue(row, out rowNodes))
                    {
                        rowNodes.Add(node.val);
                        rowNodes.Sort();
                        nodes[row] = rowNodes;
                    }
                    else
                    {
                        nodes.Add(row, new List<int> { node.val });
                    }

                    result[col] = nodes;
                }
                else
                {
                    result.Add(col, new Dictionary<int, List<int>>
                    {
                        { row, new List<int> { node.val } }
                    });
                }

                result = this.Traverse(node.left, row + 1, col - 1, result);
                result = this.Traverse(node.right, row + 1, col + 1, result);
            }

            return result;
        }
    }
}
