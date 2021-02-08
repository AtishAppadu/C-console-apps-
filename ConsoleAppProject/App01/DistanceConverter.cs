using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App is designed to convert distance in miles to the equivalent
    /// distance in feet
    /// </summary>
    /// <author>
    /// Atish Appadu version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_MILES_ = 5280;

        private double miles;

        private double feet;


        /// <summary>
        /// Run is for the program to run the changes that has been made and to test whether the program works. 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// This shows a heading when running the program 
        /// that says converting miles to feet for the user to see
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("       Convert Miles to feet     ");
            Console.WriteLine("             By Atish            ");
            Console.WriteLine("----------------------------------\n");
        }   
        

        /// <summary>
        /// The user will be prompt to input the distance in miles
        /// Input the miles as double number
        /// </summary>

        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + "feet!");
        }
    }
}
