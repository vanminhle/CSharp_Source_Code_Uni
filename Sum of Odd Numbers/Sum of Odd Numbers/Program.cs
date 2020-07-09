using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input num: ");
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 1;i <= num; i++ )
            {
                Console.WriteLine("{0}", 2 * i - 1);
                sum = sum + 2 * i - 1;
            }
            Console.WriteLine($"sum: {sum}");
        }
    }
}
