using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DataStructures
{
    public class PriorityQueue
    {
        public static void Test()
        {
            var queue = new PriorityQueue<string, int>();

            queue.Enqueue("Item A", 0);
            queue.Enqueue("Item B", 60);
            queue.Enqueue("Item C", 2);
            queue.Enqueue("Item D", 1);

            int currLargeIndex = 0;
            while(currLargeIndex == 10)
            {
                var curr = queue.Dequeue();
            }



        }
    }
}
