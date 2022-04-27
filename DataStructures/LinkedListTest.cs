using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class LinkedListTest
    {
        public static void Test()
        {
            var list = new LinkedList<int>();
            var listNode = new LinkedListNode<int>(16);

            list.AddLast(listNode);
            list.AddLast(12);

            var nextNode = listNode.Next;
            var prevNode = listNode.Previous;

            list.Find(2);


            var list1 = new LinkedList<KeyValuePair<int, int>>();
            list1.SingleOrDefault(l => l.Key == 16);
            var listItem = new KeyValuePair<int, int>(1, 2);
            list1.AddLast(listItem);
            list1.Remove(listItem);
        }
    }
}
