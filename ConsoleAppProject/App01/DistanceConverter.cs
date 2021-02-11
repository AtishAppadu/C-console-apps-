using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App has 3 features and is designed to convert distance in miles to the equivalent
    /// distance in feet, Feet to miles and miles to metres
    /// </summary>
    /// <author>
    /// Atish Appadu version 0.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES_ = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres; 


        /// <summary>
        /// Run is for the program to run the changes that has been made and to test whether the program works. 
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of Miles > ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");


            feet = InputDistance("Please enter the number of Feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");
            miles = InputDistance("Please enter the number of Miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }


        /// <summary>
        /// This shows a heading when running the program 
        /// that says converting miles to feet for the user to see
        /// </summary>
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("         Distance Converter     ");
            Console.WriteLine("             By Atish            ");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
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

   
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES_;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES_;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit, 
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}! ");
        }





    }   



        
}
