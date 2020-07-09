using System;
using System.Linq;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string result = StringRepeat(input, n);
            Console.Write(result);
        }

        private static string StringRepeat(string input, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}