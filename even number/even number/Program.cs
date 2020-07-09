using System;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n % 2 == 1);


            if (n < 0)
            {
                n = -n;
            }
            Console.WriteLine("the number is {0}", n);
        }
    }
}
