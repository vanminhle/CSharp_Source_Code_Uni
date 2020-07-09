using System;
using System.Globalization;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter String to removes: ");
            string key = Console.ReadLine();

            int index = str.IndexOf(key);

            while (index != -1)
            {
                str = str.Remove(index, key.Length);
                index = str.IndexOf(key);
            }
            Console.WriteLine(str);
        }
    }
}