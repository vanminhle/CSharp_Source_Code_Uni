using System;

namespace language
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = Console.ReadLine();
            switch (language)
            {
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English UK");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Japan":
                    Console.WriteLine("Japanese");
                    break;
                default:
                    Console.WriteLine("Invalid Country");
                    break;




            }
        }
    }
}