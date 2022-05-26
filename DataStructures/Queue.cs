using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    public class QueueDemo
    {
        public static void Test()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in queue)
            {
                Console.WriteLine(number);
            }

            queue.Dequeue();

            queue.Any(e => e.Equals("one"));
            queue.All(e => e.Equals("one"));


            int elementsCount = queue.Count;

            var queue1 = new Queue<(string, string)>();
            queue1.Enqueue(("abc", "abc"));

            var item = queue1.Dequeue();
            var item1 = item.Item1;

            queue.ToList();
            //Queue<string> queue2 = new LinkedList<string>();
        }
    }
}
