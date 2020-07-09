using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Multi: ");
            int multi = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} x {multi} = {number * multi}");
                multi++;
            }
            while (multi <= 10);
        }
    }
}
