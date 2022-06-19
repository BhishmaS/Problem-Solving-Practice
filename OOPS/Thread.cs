using System;
using System.Threading;

namespace Learning.OOPS
{
    public class ThreadDemo
    {
        public static void Test()
        {
            var t = new Thread(new ThreadStart(ThreadProc));
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                // Yield the rest of the time slice.
                Thread.Sleep(0);
            }
        }
    }
}
