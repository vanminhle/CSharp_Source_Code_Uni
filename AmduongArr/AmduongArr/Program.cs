using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the number of array elements (array <=0!) : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("input {0} Element in the array", n);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("value {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 0)
                {
                    Console.WriteLine(" positive numbers");
                }
                else if (arr[i] < 0)
                {
                    Console.WriteLine(" negative number ");
                }
                else if (arr[i] == 0)
                {
                    Console.WriteLine(" not value ");
                }





            }

        }
    }
}