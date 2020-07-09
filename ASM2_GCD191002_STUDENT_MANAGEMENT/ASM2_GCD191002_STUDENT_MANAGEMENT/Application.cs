using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ASM2_GCD191002_STUDENT_MANAGEMENT
{
    class Application
    {
        ClassRoom ClassRooms = new ClassRoom();

        public void CaseFunction()
        {
            int userChoice;
            do
            {
                Menu.MainMenu();
                userChoice = Menu.EnterUserChoice();
                try
                {
                    switch (userChoice)
                    {
                        case 1:
                            ClassRooms.EnterListOfStudents();
                            break;
                        case 2:
                            ClassRooms.DisplayListOfStudents();
                            break;
                        case 3:
                            ClassRooms.FindingHighestStudentAverage();
                            break;
                        case 4:
                            ClassRooms.FindingLowestStudentAverage();
                            break;
                        case 5:
                            ClassRooms.SortStudentsInDescendingAverage();
                            break;
                        case 6:
                            ClassRooms.StudentEvaluate();
                            break;
                        case 0:
                            Console.WriteLine("\n // YOU ARE EXIT THE PROGRAM //");
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n                         // INVALID TYPE - BACK TO MAIN MENU // ");
                }
            } while (userChoice != 0);
        }
    } 
}
