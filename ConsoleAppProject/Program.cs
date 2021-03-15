using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.
    /// 
    /// This Project has been modified by:
    /// Atish 
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming!");
            Console.WriteLine("1: Distance converter");
            Console.WriteLine("2: BMI Calculator");
            Console.WriteLine("3: StudentMarks");
            Console.WriteLine("Please choose your desired Program > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choice == "2")
            {
                App02.BMI converter = new App02.BMI();
                converter.run(); 
            }



        }

    }
}
