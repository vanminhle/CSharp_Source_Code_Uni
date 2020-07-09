using System;

namespace Grades
{
    class Program
    {
        private static void PrintInWords(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail ");
            }

            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor ");
            }

            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good ");
            }

            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very Good ");
            }

            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Exellent ");
            }
            
            else if (grade == 0)
            {
                Console.WriteLine("Your Grade is 0, thi lai");
            }
            else 
            {
                Console.WriteLine("BEST!");
            }
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            double grade = double.Parse(Console.ReadLine());

            PrintInWords(grade);

        }
    }
}
