﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.DataStructures
{
    class Stack
    {
        public void Test()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");

            // A stack can be enumerated without disturbing its contents.
            foreach (string number in stack)
            {
                Console.WriteLine(number);
            }

            stack.Pop();

            string outResult;
            stack.TryPop(out outResult);

            if (stack.TryPeek(out _))
            {
                var ele = stack.Pop();
            }

            int elementsCount = stack.Count;
        }
    }
}
