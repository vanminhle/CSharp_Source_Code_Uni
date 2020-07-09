using System;
using System.ComponentModel;

namespace Loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            while(a< 15)
            {
                b = b * a;
                a++;
            }
            Console.WriteLine(b);

        }
    }
}
