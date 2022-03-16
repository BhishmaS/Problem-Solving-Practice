using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DataStructures
{
    public class HashSet
    {
        public void Test()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);

                oddNumbers.Add((i * 2) + 1);
            }

            DisplaySet(evenNumbers);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            numbers.UnionWith(oddNumbers);
            numbers.Contains(1);

            var c = numbers.Count;

            numbers.Any(n => n > 2);

            DisplaySet(numbers);
        }

        public void DisplaySet(HashSet<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

    }
}
