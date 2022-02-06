using System;
using System.Linq;
using System.Text;

namespace Learning.DataStructures
{
    class Strings
    {
        public void Test()
        {
            string stringO = new string(new char[] { 'a', 'b' });
            string stringO1 = new string("ab");

            string str = $"This is interpolation {stringO} {stringO1}";
            str.EndsWith("");
            str.LastIndexOf("");
            str.IndexOf("");
            str.ToLower();
            str.Substring(5, 10);
            str.Remove(2, 1);
            str.Replace('a', 'b');
            string newStr = str.Reverse().ToString();
            string.Join("", str.Reverse());
            str.Insert(0, "test");

            int x = str[2] - '0';
            str += '2';

            str.All(s => char.IsUpper(s));
            str.Substring(5, 10).All(s => char.IsUpper(s));

            var split = str.Split(" ");
            var len = split.Length;

            StringBuilder validString = new StringBuilder("");
            //validString.Remove()

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
            Console.WriteLine(sb);  // displays 0123456789
            // Copy one character of the string (not possible with a System.String)
            sb[0] = sb[9];
            Console.WriteLine(sb);  // displays 9123456789
            Console.WriteLine();
        }
    }
}
