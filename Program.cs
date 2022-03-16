using Learning.LeetCode;
using Learning.MySamples;
using System;
using static Learning.LeetCode.DeleteDuplicates;

namespace Learning
{
    class Program
	{
		public static void Main(string[] args)
		{
			//new CombinationSum().FindCombinationSum(new int[] { 2, 3, 6, 7 }, 7);
			//DiagonalMatrix.PrintCrossElements();
			var node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, null)))))));
			var newNode = DeleteDuplicates.DeleteDuplicatesInList(node);

		}
	}
}
