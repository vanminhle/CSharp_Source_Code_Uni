using System;

namespace Special_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            if (n < 1 || n > 100)
                Console.WriteLine("Invalid Input!");
            else
            {
              
                int first = n / 10;

                int last = n % 10;

                int sum = first + last;

                int pro = first * last;

                if ((sum + pro) == n)
                {
                    Console.WriteLine(n + " is a Special Number");
                }
                else
                {
                    Console.WriteLine(n + " is not a Special Number");
                }
            }
        }

    }

}
   
