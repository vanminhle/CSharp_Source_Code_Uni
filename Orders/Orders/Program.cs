using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Order: ");
            string order = Console.ReadLine();
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (order)
            {
                case "coffee":
                    coffee(num);
                    break;
                case "water":
                    water(num);
                    break;
                case "coke":
                    coke(num);
                    break;
                case "snacks":
                    snacks(num);
                    break;
            }
        }
        private static void coffee(int num)
        {
            Console.WriteLine(1.50 * num);
        }

        private static void water(int num)
        {
            Console.WriteLine(1.00 * num);
        }

        private static void coke(int num)
        {
            Console.WriteLine(1.40 * num);
        }

        private static void snacks(int num)
        {
            Console.WriteLine(2.00 * num);
        }
    }
}
