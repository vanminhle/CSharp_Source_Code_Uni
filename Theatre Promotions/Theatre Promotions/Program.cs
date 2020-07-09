﻿using System;
using System.IO;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Day: ");
            var day = Console.ReadLine().ToLower();
            Console.Write("Enter Age: ");
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (day == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) 
                {
                    price = 12;
                }
                else if(age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if(age > 64 && age <= 122)
                {
                    price = 12;
                }
            }

            else if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) 
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }

            else if (day == "holiday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) 
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
           

            if (price != 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
