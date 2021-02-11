﻿using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance measured 
    /// in one unit (fromUnit) and it will calculate and provid output of the equivalent distance 
    /// in another Unit (toUnit). 
    /// 
    /// </summary>
    /// <author>
    /// Atish Appadu version 0.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES_ = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";
        public const string MILES = "miles";
        public const string METRES = "metres";
        
        
        private double fromDistance; 
        private double toDistance;

        private string fromUnit;
        private string toUnit; 

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// Run is for the program to run the changes that has been made and to test whether the program works. 
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance(); 

            OutputDistance();
        }

        private void CalculateDistance()
        {
           if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES_;
            }
           else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES_; 
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit =  ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit; 
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


        /// <summary>
        /// This shows a heading when running the program 
        /// that says converting miles to feet for the user to see
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("         Distance Converter     ");
            Console.WriteLine("             By Atish            ");
            Console.WriteLine("----------------------------------\n");
        }   
        

        /// <summary>
        /// The user will be prompt to input the distance in miles
        /// Input the miles as double number
        /// </summary>

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}! \n");
        }





    }   



        
}
