using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2_GCD191002_STUDENT_MANAGEMENT
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("\n ||=====================  STUDENT ENGLISH GRADE INFORMATION  =======================||");
            Console.WriteLine(" ||----------------------Choose one of the following options------------------------||");
            Console.WriteLine(" ||Press 1 : Enter Student Information                                              ||");
            Console.WriteLine(" ||Press 2 : Display List of Student                                                ||");
            Console.WriteLine(" ||Press 3 : Display Student having the highest Grades                              ||");
            Console.WriteLine(" ||Press 4 : Display Student having the lowest Grades                               ||");
            Console.WriteLine(" ||Press 5 : Sort Students In Descending Average                                    ||");
            Console.WriteLine(" ||Press 6 : Pass Or NOT Pass                                                       ||");
            Console.WriteLine(" ||                              Press 0 To Exit Program                            ||");
            Console.WriteLine(" ||=================================================================================||");
            Console.Write(" > Input your choice (1 -> 6) : ");
        }

        public static int EnterUserChoice()
        {
            int userChoice;
            bool isValid;
            do
            {
                isValid = int.TryParse(Console.ReadLine(), out userChoice);
                if (!isValid == false)
                {
                    Console.Clear();
                }
                else if (userChoice <= 0 || userChoice >= 6)
                {
                    Console.Clear();
                    MainMenu();
                }
            } while (isValid == false);
            return (userChoice);
        }
    }
}
