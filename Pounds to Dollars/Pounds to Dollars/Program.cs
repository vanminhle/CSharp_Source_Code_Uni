using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Pounds to Dollars");
            Double pounds = double.Parse(Console.ReadLine());
            double dollars;

            dollars = pounds * 1.23 / 1;

            Console.WriteLine("dollars :" + dollars);
        }
    }
}
