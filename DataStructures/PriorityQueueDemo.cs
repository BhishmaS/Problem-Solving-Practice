using System.Collections.Generic;

namespace Learning.DataStructures
{
    public class PriorityQueueDemo
    {
        public static void Test()
        {
            var queue = new PriorityQueue<string, int>();
            var queue1 = new PriorityQueue<string, int>(new QueueComparer());
            // var queue2 = new PriorityQueue<int>(); -- should contain 2 arguments

            queue.Enqueue("Item A", 0);
            queue.Enqueue("Item B", 60);
            queue.Enqueue("Item C", 2);
            queue.Enqueue("Item D", 1);

            int currLargeIndex = 0;
            while(currLargeIndex == 10)
            {
                var curr = queue.Dequeue();
            }

            while (queue.Count == 0)
            {

            }


            queue.Peek();
        }

        public class QueueComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x > y ? -1 : 1;
            }
        }
    }
}
