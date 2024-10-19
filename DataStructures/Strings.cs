using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.DataStructures
{
    public class StringsDemo
    {
        public static void Test()
        {
            string stringO = new string(new char[] { 'a', 'b' });
            string stringO1 = new string("ab");
            String strObject = new String("abc"); 
            var ch = strObject[2];

            string str = $"This is interpolation {stringO} {stringO1}";
            str.EndsWith("");
            str.LastIndexOf("");
            str.IndexOf("");
            str.ToLower();
            str.Substring(5, 10);
            str.Substring(5).All(ch => ch == '*');
            str.Remove(2, 1);
            str.Replace('a', 'b');
            str.Select(c => c);
            str.Where(c => char.IsLetter(c));
            str.Equals("test");

            // string newStr = str.Reverse().ToString(); -- not working ("System.Linq.Enumerable+ReverseIterator`1[System.Char]")
            string.Join("", str.Reverse()); // string
            str.Insert(0, "test");

            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedString = new string(charArray);
            str.Trim();

            int x = str[2] - '0';
            str += '2';

            var hash = str.GetHashCode();

            str.All(s => char.IsUpper(s));
            str.Substring(5, 10).All(s => char.IsUpper(s));

            // List<string> split = str.Split(' '); Error as it retuns Array (String[])
            IList<string> split = str.Split(' ');
            var len = split.Count;
            var intNum = int.Parse("1");
            var n = char.GetNumericValue('1');

            var dict = str.ToDictionary(c => c, c => 1);

            //var newStr = string.Copy(str);

            StringBuilder validString = new StringBuilder("");
            //validString.Remove()

            StringBuilder string1 = new StringBuilder(123);
            //string1.SubString();


            str.Contains('a');
            char c = 'a';
            str = str + c;

            if (char.IsLetterOrDigit('a'))
            {

            }

            string.IsNullOrEmpty(str);

            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");

            //// String Builder
            var sb = new StringBuilder();
            // Create a string composed of numbers 0 - 9
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }

            char.IsNumber('2');
            char.IsLower('a');

            sb.Remove(1, 1);
            int.Parse(sb.ToString());
            sb.Insert(1, "aa");
            sb.Replace("a", "b", 2, 1);
            sb.Remove(sb.Length - 1, 1);

            sb.ToString().Reverse().ToString();

            Console.WriteLine(sb.ToString());  // displays 0123456789
            // Copy one character of the string (not possible with a System.String)
            sb[0] = sb[9];
            Console.WriteLine(sb);  // displays 9123456789
            Console.WriteLine();

            // int sbLen = sb.Length;
            //// see above line, your mind almost thinks the same while following a similar namming conventions
            int sbLen = sb.Length;

            //double d = "123456";
            //d.ToString("G", CultureInfo.InvariantCulture);

            string.Compare(str, "aaBBc", StringComparison.InvariantCulture);
            string.Compare(str, "aaBBc");
            string.Compare("a", "A", StringComparison.Ordinal);
        }
    }
}
