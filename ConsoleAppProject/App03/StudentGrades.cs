using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        public const int Nostudents = 10;
        public const int HighestMark = 100;
        public const int LowestMark = 0;
        public const int GradeA = 70;
        public const int GradeB = 60;
        public const int GradeC = 50;
        public const int GradeD = 40;

        public const int GradeProfile = "Please see to the grade profile";

        //variables and getset method used to make it easier to access for other classes
        // arrays
        public string[] Students;
        public int[] Marks;
        public int[] GradeProfile;
        public int[] StatMarks; 

        public double Mean { get; set; }
        public double Minimum { get; set; }
        public int Maximum { get; set; }

        public string options;

        //students names array 

        public StudentGrades()
        {
            Students = new string[]
            {
                "James","jones","Rico","Pablo","Jess","Manny","luke","Grabriel","Aniela","Hinori"

            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            //This is for the Menu to display for the user

            public void UserSelect()
            {
                bool carryOn = true;
                do
                {
                    Console.WriteLine("Hello, welcome to Student Grades!");
                    Console.WriteLine("       By Atish     ");
                    Console.WriteLine("Please choose from the List >> ");
                    string choice = DisplayChoices();

                    ExecuteChoices(choice);
                } while (carryOn);
                Quit();
          
           
            
            }

            // lets the user have the option to choose one from 4 methods 
            private static string DisplayChoices()
            {
                Console.WriteLine();
                Console.WriteLine("1: Input Marks");
                Console.WriteLine("2: Output Marks");
                Console.WriteLine("3: Output Statistics");
                Console.WriteLine("4: Output Grades Profile");
                Console.WriteLine("5: Exit Program");
                Console.WriteLine();

                Console.WriteLine();
                string choice = Console.ReadLine();

                return choice; 
            }

            //executes the decision made by the user. 

        }


    }
}
