using System;

namespace Printing_Triangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)

            for (int line = n - 1; line >= 1; line--);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}