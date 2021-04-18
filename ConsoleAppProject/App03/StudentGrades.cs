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
        public Grades[] Grade;

        public const int Fail = 0;
        public const int FirstClass = 70;
        public const int UpperSecondClass = 60;
        public const int LowerSecondClass = 50;
        public const int ThirdClass = 40;
        
        /// <summary>
        /// THe method run is to run the program with an implemented 
        /// restart function for the user to re-open the program if something happens.
        /// </summary>
        public void run()
        {
            string restart;
            ConsoleHelper.OutputHeading("Student Marks");

            do
            {
                SelectChoice();

                Console.WriteLine("Would you like to open the program: yes/no");
                restart = Console.ReadLine().ToLower();
            }
            while (restart == "yes");
            {
                Console.WriteLine("The program has been restarted");
            }
        }

        public void SelectChoice()
        {
            string[] choices = { "1: Input Marks", "2: Display Grade Profile" };
            int choice = ConsoleHelper.SelectChoice(choices); 
            
            if (choice == 1)
            {
                InputMarks();
            }
            else if (choice == 2)
            {
                DisplayStudentData(); 
            }

            Console.WriteLine("Would you like to view the Grade Profile: Yes/No");
            string choice2 = Console.ReadLine().ToLower();

            if (choice2 == "yes")
            {
                DisplayStudentData();
            }
        }







        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("    Welcome to Student Marks!   ");
            Console.WriteLine("         Made by Atish          ");
            Console.WriteLine("\n------------------------------");
        }


        /// <summary>
        /// The DisplayStudentData is to show the student data that 
        /// consists of their names and marks
        /// </summary>
        public void DisplayStudentData()
        {
            for (int i = 0; 1 < Students.Length; i++)
            {
                Console.WriteLine("Student Name: " + Students[i] + 
                    "\nStudent Mark " + Marks[i] + "\nGrades" + CalculateGrade(Marks[i]) + "\n") ;
            }
        }

        /// <summary>
        /// This method is to calculate the mean of the total marks 
        /// </summary>
        public void CalculateMinMaxandMean()
        {
            int min = Marks[0];
            int max = Marks[0];

            double numCount = 0;
            double mean = 0;

            for (int i = 0; i < Marks.Length; i++)
            {
                if (min > Marks[i])
                {
                    min = Marks[i];
                }
                if (max < Marks[i])
                {
                    max = Marks[i];
                }

                mean += Marks[1];
                numCount++;

            }
            Console.WriteLine("The minimum marks are " + min +
                 "\nThe maximum marks are " + max + "\nThe mean marks are " + mean / numCount);
        }

        public void CalculateGradeProfile()
        {
            int counterA = 0, counterB = 0, counterC = 0, counterD = 0, counterF = 0;

            ConsoleHelper.OutputTitle("Grade Profile");

            for (int i = 0; i < Grade.Length; i++)
            {
                Grade[i] = CalculateGrade(Marks[i]);
            }

            for (int i = 0; i < Grade.Length; i++)
            {
                if (Grade[i] == Grades.A)
                {
                    counterA++;
                }

                if (Grade[i] == Grades.B)
                {
                    counterB++;
                }

                if (Grade[i] == Grades.C)
                {
                    counterC++;
                }

                if (Grade[i] == Grades.D)
                {
                    counterD++;
                }

                if (Grade[i] == Grades.F)
                {
                    counterF++;
                }
            }
            DisplayPercentage("A", counterA);
            DisplayPercentage("B", counterB);
            DisplayPercentage("C", counterC);
            DisplayPercentage("D", counterD);
            DisplayPercentage("F", counterF);
        }


        /// <summary>
        /// This method Calculates the percentage of the marks people were given 
        /// based on the given grade counter.
        /// </summary>
        /// <param name="GradeCounter"></param>
        /// <returns></returns>
        public double CalculatePercentage(int GradeCounter)
        {
            return (GradeCounter * 100) / (Students.Length);
        }


        /// <summary>
        /// This method "Display Percentage" is to show the user what percentage that has been 
        /// given based on the marks 
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="GradeCounter"></param>
        public void DisplayPercentage(string grade, int GradeCounter)
        {
            Console.WriteLine($"The percentage of students with grade {grade} : > " + CalculatePercentage(GradeCounter) + "%"); ;
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
            Console.WriteLine("\nMark has been entered \n");
        }

        /// <summary>
        /// This method is to calculate the grades for the students. 
        /// </summary>

        public Grades CalculateGrade(int Marks)
        {
            if (Marks >= Fail &&Marks < ThirdClass)
            {
                return Grades.F;
            }
            else if (Marks >= ThirdClass && Marks < LowerSecondClass )
            {
                return Grades.D;
            }
            else if (Marks >= LowerSecondClass && Marks < UpperSecondClass)
            {
                return Grades.C;
            }
            else if (Marks >= UpperSecondClass && Marks < FirstClass)
            {
                return Grades.B; 
            }
            else
            {
                return Grades.A; 
            }
            

        
        }


        





        }
        

    }



