using System;
using System.Text;

namespace RepearString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter N Number to Repeat");
            int num = Convert.ToInt32(Console.ReadLine());

            var output = new StringBuilder(str.Length * num).Insert(0, str, num).ToString();

            Console.WriteLine(output);
        }
    }
}
