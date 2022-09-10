using System;
using System.Collections.Generic;

namespace Learning.DataStructures
{
    public class PriorityQueueDemo
    {
        public static void Test()
        {
            var queue = new PriorityQueue<string, int>();
            var queue1 = new PriorityQueue<string, int>(new QueueComparer());
            // OR
            var queue2 = new PriorityQueue<string, int>(Comparer<int>.Create((x, y) => x > y ? -1 : 1));

            var queue3 = new PriorityQueue<(int, int), int>();
            // var queue2 = new PriorityQueue(); -- should contain 2 arguments

            var pqueue = new PriorityQueue<int[], double>(
                Comparer<double>.Create((x, y) => (int)(y - x))
            );

            var item = queue2.Dequeue();
            //item.Item1;

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

            foreach (var (Element, Priority) in queue.UnorderedItems)
            {
                Console.WriteLine(Element + " " + Priority);
            }

            //var list = queue.ToList();
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
