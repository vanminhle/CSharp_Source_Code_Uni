using System;

namespace M_to_Km
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Meter to Convert");
            Double meters = double.Parse(Console.ReadLine());
            double kilometers;

            kilometers = meters / 1000;

            Console.WriteLine("kilometers :" + kilometers);

        }
    }
}
