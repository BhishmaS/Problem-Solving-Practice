using System.Collections.Generic;

namespace Learning.DataStructures
{
    public class LinkedListTest
    {
        public static void Test()
        {
            var list = new LinkedList<int>();
            var listNode = new LinkedListNode<int>(16);

            list.AddLast(listNode);

            var nextNode = listNode.Next;
            var prevNode = listNode.Previous;
        }
    }
}
