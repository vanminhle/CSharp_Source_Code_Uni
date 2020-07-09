using System;

namespace ArrayOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i,num, odd = 0, even = 0;

            Console.Write("Enter number of elements to be stored: ");
            num = int.Parse(Console.ReadLine());
            
            for(i = 0; i < num; i++)
            {
                Console.Write("Element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //checking odd even
            for (i = 0; i < num; i++)
            {
                if (arr1[i] % 2 == 0) {
                    arr2[even] = arr1[i];
                    even++;
                }
                else {
                    arr3[odd] = arr1[i];
                    odd++; 
                }
            }

            Console.WriteLine("Number of Even Elements are :  ");
            for (i = 0; i < even; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.WriteLine("\n Number of Odd Elements are :  ");
            for (i = 0; i < odd; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }

        }
    }
}
