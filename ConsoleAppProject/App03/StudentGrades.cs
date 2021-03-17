using System;
using ConsoleAppProject.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        public string[] Students;
        public int[] Marks;

        public const int Fail = 0;
        public const int GradeA = 70;
        public const int GradeB = 60;
        public const int GradeC = 50;
        public const int GradeD = 40;
        
        public void run()
        {

        }
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("    Welcome to Student Marks!   ");
            Console.WriteLine("         Made by Atish          ");
            Console.WriteLine("\n------------------------------");
        }
        public void InputMarks()
        {
            int mark = 0;

            Marks = new int[10];
            Students = new string[]
            {
                "James","Jones","Hinori","Aniela","Anna","Sam","Billy","Peter","Tom","Wanda"
            };

            for(int i = 0; i<Students.Length; i++)
            {
                mark = (int)ConsoleHelper.InputNumber(
                    "Please Input Student Mark" + Students[i] + ">", 0, 100);
                Marks[i] = mark;
            }
            Console.WriteLine("\nYou have entered a Mark for the students \n");
        }


    }

}

