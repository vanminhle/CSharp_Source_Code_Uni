using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM2_GCD191002_STUDENT_MANAGEMENT
{
    class ClassRoom
    {
        List<Student> Students = new List<Student>();

        //nhap list hs

        public void EnterListOfStudents()
        {
            Console.Clear();
            //enter so hoc sinh can nhap
            Student student;
            int numberofStudents;
            Console.WriteLine("\n //ENTER STUDENTS INFORMATION//");
            Console.WriteLine(" ------------------------------------------------------");
            Console.Write(" Enter Number Of Students : ");
            do
            {
                numberofStudents = int.Parse(Console.ReadLine());
                if (numberofStudents <= 0 || numberofStudents > 20)
                {
                    Console.Write(" ||Enter Number Of Students Again, Maximum Number Of Students Is 20 : ");
                }
            } while (numberofStudents < 0 || numberofStudents > 20);
            //enter thong tin cua hoc sinh
            for (int i = 0; i < numberofStudents; i++)
            {
                student = new Student();
                Console.WriteLine("\n Enter Student {0} information", (i + 1));
                //enter id hoc sinh
                Console.Write(" 1 / Enter Student Id: ");
                {
                    do
                    {
                        student.StudentId = int.Parse(Console.ReadLine());
                        if (student.StudentId < 100 || student.StudentId > 999)
                        {
                            Console.WriteLine(" ||Error!, Student ID Should Have 3 Numbers. Please Enter Again!");
                            Console.Write(" 1 / Enter Student Id: ");

                        }
                        else if (CheckDuplicateId(student.StudentId) == true)
                        {
                            Console.WriteLine(" ||Error!, Student ID Already Exists. Please Enter Again!");
                            Console.Write(" 1 / Enter Student Id: ");
                        }
                        else break;
                    }while ((CheckDuplicateId(student.StudentId) == true) || student.StudentId > 100 || student.StudentId < 999);
                }
                //enter name hoc sinh
                Console.Write(" 2 / Enter Student Name: ");
                {
                    student.StudentName = Console.ReadLine();
                }
                //diem doc
                Console.WriteLine(" Enter Student English Grade");
                Console.Write(" 1 / Enter Student Reading Grade: ");
                {
                    do
                    {
                        student.Reading = double.Parse(Console.ReadLine());
                        if (student.Reading > 10 || student.Reading < 0)
                        {
                            Console.WriteLine(" ||Error!, Reading Grade Should From 0 to 10. Please Enter Again!");
                            Console.Write(" 1 / Enter Student Reading Grade: ");
                        }
                        else break;
                    } while (student.Reading < 10 || student.Reading > 0);
                }
                //diem viet
                Console.Write(" 2 / Enter Student Writing Grade: ");
                {
                    do
                    {
                        student.Writing = double.Parse(Console.ReadLine());
                        if (student.Writing > 10 || student.Writing < 0)
                        {
                            Console.WriteLine(" ||Error!, Writing Grade Should From 0 to 10. Please Enter Again!");
                            Console.Write(" 2 / Enter Student Writing Grade: ");
                        }
                        else break;
                    } while (student.Writing < 10 || student.Writing > 0);
                }
                //diem noi
                Console.Write(" 3 / Enter Student Speaking Grade: ");
                {
                    do
                    {
                        student.Speaking = double.Parse(Console.ReadLine());
                        if (student.Speaking > 10 || student.Speaking < 0)
                        {
                            Console.WriteLine(" ||Error!, Speaking Grade Should From 0 to 10. Please Enter Again!");
                            Console.Write(" 3 / Enter Student Speaking Grade: ");
                        }
                        else break;
                    } while (student.Speaking < 10 || student.Speaking > 0);
                }
                //diem Nghe
                Console.Write(" 4 / Enter Listening Grade: ");
                {
                    do
                    {
                        student.Listening = double.Parse(Console.ReadLine());
                        if (student.Listening > 10 || student.Listening < 0)
                        {
                            Console.WriteLine(" ||Error!, Listening Grade Should From 0 to 10. Please Enter Again!");
                            Console.Write(" 4 / Enter Student Listening Grade: ");
                        }
                        else break;
                    } while (student.Listening < 10 || student.Listening > 0);
                }
                Students.Add(student);
            }
            Console.Write("\n || PRESS ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear();

        }

        private bool CheckDuplicateId(int id)
        {
            var existStudent = Students.Where(s => s.StudentId == id).ToList();
            if (existStudent.Count != 0)
            {
                return true;
            }
            return false;
        }


        //display
        public void DisplayListOfStudents()
        {
            Console.Clear();
            Console.WriteLine("\n //STUDENT LIST INFORMATION//");
            Console.WriteLine(" ||ID   ||Name                      ||Reading||Writing||Speaking||Listening||Average||");
            Console.WriteLine(" ||---------------------------------------------------------------------------------||"); 
            foreach (var student in Students)
            {
                student.StudentInformation();
            }
            Console.Write("\n || ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear();
        }
        //tim diem lon nhat
        public double FindingHighestStudentAverage()
        {
            Console.Clear();
            Console.WriteLine("\n //STUDENTS HAVE HIGHEST AVERAGE//");
            int temp = 0;
            double highestAverage = Students[0].StudentAverage();
            for (int i = 1; i < Students.Count; i++)
            {
                if (Students[i].StudentAverage() > Students[temp].StudentAverage())
                {
                    temp = i;
                    highestAverage = Students[i].StudentAverage();
                }
            }
            foreach (Student student in Students)
                if (student.StudentAverage() == Students[temp].StudentAverage())
                {
                    Console.WriteLine(" ||ID : {0}||NAME: {1}||AVERAGE: {2}", 
                        student.StudentId, student.StudentName, student.StudentAverage());
                }
            Console.Write("\n || ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear(); 
            return temp;
        }
        //diem be nhat
        public double FindingLowestStudentAverage()
        {
            Console.Clear();
            Console.WriteLine("\n //STUDENTS HAVE LOWEST AVERAGE//");
            int temp = 0;
            double lowestAverage = Students[0].StudentAverage();
            for (int i = 1; i < Students.Count; i++)
            {
                if (Students[i].StudentAverage() < Students[temp].StudentAverage())
                {
                    temp = i;
                    lowestAverage = Students[i].StudentAverage();
                }
            }
            foreach (Student student in Students)
                if (student.StudentAverage() == Students[temp].StudentAverage())
                {
                    Console.WriteLine(" ||ID : {0}||NAME: {1}||AVERAGE: {2}", student.StudentId, student.StudentName, student.StudentAverage());

                }
            Console.Write("\n || ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear();
            return temp;
        }
        //Top Student
        public void SortStudentsInDescendingAverage()
        {
            Console.Clear();
            Console.WriteLine("\n //SORT STUDENTS IN DESCENDING AVERAGE//");
            Student temp;
            for (int i = 0; i < Students.Count; i++)
            {
                for (int j = i + 1; j < Students.Count; j++)
                {
                    if (Students[j].StudentAverage() > Students[i].StudentAverage())
                    {
                        temp = Students[i];
                        Students[i] = Students[j];
                        Students[j] = temp;
                    }
                }
                Console.WriteLine(" ||{0}||NAME: {1}||AVERAGE: {2}", (i + 1), Students[i].StudentName, Students[i].StudentAverage());
            }
            Console.Write("\n || ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear();
        }
        //danh gia hoc sinh
        public void StudentEvaluate()
        {
            Console.Clear();
            Console.WriteLine("\n //PASS OR NOT PASS//");
            Console.WriteLine(" ||ID   ||Name                      ||Average   ||Rating  ||");
            Console.WriteLine(" ||-------------------------------------------------------||"); 
            foreach (var studentEvaluate in Students)
            {
                if (studentEvaluate.StudentAverage() < 5)
                {
                    Console.WriteLine(" ||{0,-5}||{1,-26}||{2,-10}||NOT PASS||", studentEvaluate.StudentId, studentEvaluate.StudentName, studentEvaluate.StudentAverage());
                }
                else if (studentEvaluate.StudentAverage() >= 5)
                {
                    Console.WriteLine(" ||{0,-5}||{1,-26}||{2,-10}||PASS    ||", studentEvaluate.StudentId, studentEvaluate.StudentName, studentEvaluate.StudentAverage());
                }
            }
            Console.Write("\n || ENTER TO RETURN MAIN MENU ||");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
