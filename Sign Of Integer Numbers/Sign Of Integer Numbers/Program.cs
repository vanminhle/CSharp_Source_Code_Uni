using System;

namespace Sign_Of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative", n);
            }
            else
                Console.WriteLine("The number 0 is zero");
        }
    }
}
