﻿using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}
