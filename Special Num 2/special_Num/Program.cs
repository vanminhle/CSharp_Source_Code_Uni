using System;

namespace special_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber;
            int secondNumber;
            int sum;

            for (int i = 1; i <= n; i++ );
            {
                sum = 0;
                firstNumber = 1;
                while(firstNumber/10 >0)
                {
                    secondNumber = firstNumber % 10;
                    firstNumber /= 10;
                    sum = firstNumber + secondNumber;
                }
                if (sum == 7 || sum == 5) 
                {
                    Console.WriteLine("-> True");
                }
                else
                {
                    Console.WriteLine("-> False");
                }
            }


        }
    }
}
