using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2_GCD191002_STUDENT_MANAGEMENT
{
    class Student
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public double Reading { get; set; }
        public double Writing { get; set; }
        public double Speaking { get;  set; }
        public double Listening { get; set; }



        public void StudentInformation()
        {
            Console.WriteLine(" ||{0,-5}||{1,-26}||{2,-7}||{3,-7}||{4,-8}||{5,-9}||{6,-7}||",
                 StudentId, StudentName, Reading, Writing, Speaking, Listening, StudentAverage());
        }

        public double StudentAverage()
        {
            double studentAverage = Math.Round(((Reading + Writing + Speaking + Listening) / 4), 1);
            return studentAverage;
        }
    }
}
