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
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            DistanceConverter converter = new DistanceConverter();
            converter.MilesToFeet();
            converter.FeetToMiles();
            converter.MilesToMetres();
        }
    }
}
