using System;
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
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        private double miles;
        private double feet;
        private double metres;
        string choice2;
        string choice1;


        // This is a run method which lets the program to run with all the methods. 
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
            Console.WriteLine();
            InputMiles();
            CalculateMetres();
            OutputMetres();
            Console.WriteLine();
            InputFeets();
            CalculateMiles();
            OutputMiles();
          
            Console.WriteLine();
            SelectInputUnit();
            CalculateDistance();
        }
        // The method is to calculate miles into the metres.
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        // A print method to show the output of miles into metres.
        private void OutputMetres()
        {
            Console.WriteLine(miles + "is equiavalent to " + metres + "metres");
        }

        // heading output for the end user to see when opening the program.
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("     Distance Converter       ");
            Console.WriteLine("         By Atish             ");
            Console.WriteLine("----------------------------\n");
        }


        // Prompt the user to enter the miles 
        // 
        private void InputMiles()
        {
            Console.WriteLine("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        // My input distance method for choosing which type
        // of unit to convert from.
        double inputDistance = 0;
        private void InputDistance()
        {
            Console.WriteLine("Please enter the distance > ");
            string value = Console.ReadLine();
            inputDistance = Convert.ToDouble(value);

        }

        // A method asking for the input as feet and storing it inside
        // a string value. Then storing it in feet.
        private void InputFeets()
        {
            Console.WriteLine("Please enter the number of feet >  ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        // This method is for calculating feet into miles
        private double CalculateMiles()
        {
            return miles = feet / 5280;
        }

        // The method will calculate the feet
        // 
        private double CalculateFeet()
        {
            return feet = miles * 5280;
        }

        // It will give out the output in feet.
        // 
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet");
        }

        // Print out the output in miles.
        // 
        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is  " + Convert.ToDouble(miles) + "miles");
        }

        
        // The input unit method essentially provides a Menu for the end user to choose from
        // the different services. 
        private void SelectInputUnit()
        {
            Console.WriteLine("Please choose the unit to convert from");
            Console.WriteLine("1. Metres" + "\n2. Miles\n" + "3. Feet");
            choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Console.WriteLine("You have chosen Metres ");
                SelectOutputUnit();
            }

            else if (choice1 == "2")
            {
                Console.WriteLine("You have chosen Miles");
                SelectOutputUnit();
            }

            else if (choice1 == "3")
            {
                Console.WriteLine("You have chosen Feet");
                SelectOutputUnit();
            }

            else
            {
                Console.WriteLine("Select 1 2 or 3");
            }

        }

       
        // The output unit method is showing which service that has been chosen from the menu
        // and that will determine the action of the method.
        private void SelectOutputUnit()
        {
            Console.WriteLine("\nPlease select a distance to convert into\n");
            Console.WriteLine("1. Metres" + "\n2. Miles\n" + "3. Feet");
            Console.WriteLine("Please enter your choice ");
            choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.WriteLine("You have chosen Metres ");
            }

            else if (choice2 == "2")
            {
                Console.WriteLine("You have chosen Miles");
            }

            else if (choice2 == "3")
            {
                Console.WriteLine("You have chosen Feet");
            }

            else
            {
                Console.WriteLine("Select 1 2 or 3");
            }
        }

        double outputDistance = 0;

        // The method to calculate the distance of the users 
        // two selected units.
        private void CalculateDistance()
        {
            if (choice1 == "1" && choice2 == "1")
            {
                Console.WriteLine("\nConverting metres into metres\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " metres");
            }

            else if (choice1 == "1" && choice2 == "2")
            {
                Console.WriteLine("\nConverting metres into miles\n");
                InputDistance();
                outputDistance = inputDistance / METRES_IN_MILES;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " miles");
            }

            else if (choice1 == "1" && choice2 == "3")
            {
                Console.WriteLine("\nConverting metres into feet\n");
                InputDistance();
                outputDistance = inputDistance * FEET_IN_METRES;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " feet");
            }

            else if (choice1 == "2" && choice2 == "1")
            {
                Console.WriteLine("\nConverting miles into metres\n");
                InputDistance();
                outputDistance = inputDistance * METRES_IN_MILES * 1;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " metres");
            }

            else if (choice1 == "2" && choice2 == "2")
            {
                Console.WriteLine("\nConverting miles into miles\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " miles");
            }

            else if (choice1 == "2" && choice2 == "3")
            {
                Console.WriteLine("\nConverting miles into feet\n");
                InputDistance();
                outputDistance = inputDistance * 5280;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " feet");
            }

            else if (choice1 == "3" && choice2 == "1")
            {
                Console.WriteLine("\nConverting feet into metres\n");
                InputDistance();
                outputDistance = inputDistance / FEET_IN_METRES;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " metres");
            }

            else if (choice1 == "3" && choice2 == "2")
            {
                Console.WriteLine("\nConverting feet into miles\n");
                InputDistance();
                outputDistance = inputDistance / 5280;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " miles");
            }

            else if (choice1 == "3" && choice2 == "3")
            {
                Console.WriteLine("\nConverting feet into feet\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " feet ");
            }
        }

    }

}



        
