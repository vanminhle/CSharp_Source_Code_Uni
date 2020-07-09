using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter character
            Console.WriteLine("Enter Character: ");
            char ch = char.Parse(Console.ReadLine());

            //checking character
            if (ch >= 'A' && ch <= 'Z') 
            {
                Console.WriteLine(ch + " is uppercase character");
            }
            else            
            {
                Console.WriteLine(ch + " is lowercase character");
            }

            
        }
    }
}
