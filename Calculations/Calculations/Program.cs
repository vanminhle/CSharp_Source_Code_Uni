using System;

namespace Calculations
{
    class Program
    {
        private static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        private static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static void divide(int a, int b)
        {
            double c = (double) a / (double) b;
            Console.WriteLine(c);
        }
        private static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    add(a, b);
                    break;
                case "subtract":
                    subtract(a, b);
                    break;
                case "multiply":
                    multiply(a, b);
                    break;
                case "divide":
                    divide(a, b);
                    break;
            }
            Console.ReadKey();
        }
    }
}
