using System; 
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Atish version 0.1
    /// </author>
    public class BMI
    {
        public double Height;
        public double Weight;
        public string Choice1;
        public double HeightinMetres;
        public double HeightinFeet;
        public double WeightinKG;
        public double WeightinPounds;
        public double MetricBMI;
        public double ImperialBMI;
        public double HeightinInches;
        public double WeightinStones;
        public double WeightImperial;
        public double HeightImperial;

        public void run()
        {
            OutputHeading();
            SelectUnitType();
            CalculateMetric();
            CalculateImperial();
            displaybameMessage();
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------");
            Console.WriteLine("    BMI Calculator   ");
            Console.WriteLine("      By Atish       ");
            Console.WriteLine("\n-------------------");
        }

        private void SelectUnitType()
        {
            Console.WriteLine(" 1. Metric Units ");
            Console.WriteLine(" 2. Imperial Units ");
            Console.WriteLine(" Please input your choice > ");
            string Userchoice = Console.ReadLine();

            if (Userchoice == "1")
            {
                Console.WriteLine("Please enter your Height in Metres");
                string HeightM = Console.ReadLine();
                HeightinMetres = Convert.ToDouble(HeightM);

                Console.WriteLine("Please Enter your Weight in KG");
                string WeightKG = Console.ReadLine();
                WeightinKG = Convert.ToDouble(WeightKG);
                CalculateMetric();
                DisplayBMI(MetricBMI);
            }
            else if (Userchoice == "2")
            {
                Console.WriteLine("Please enter your Height in Feet and Inches > ");
                Console.WriteLine("Please enter your Height in Feet");
                string HeightFI = Console.ReadLine();
                HeightinFeet = Convert.ToDouble(HeightFI);

                Console.WriteLine("Please enter your Height in Inches");
                string Heightin = Console.ReadLine();
                HeightinInches = Convert.ToDouble(Heightin);


                Console.WriteLine(" Please enter your Weight in Pounds ");
                string WeightPounds = Console.ReadLine();
                WeightinPounds = Convert.ToDouble(WeightPounds);
                CalculateImperial();
                DisplayBMI(ImperialBMI);
            }
            else 
            {
                Console.WriteLine(" Please input either option 1 or 2 ");
            }
        }
            
        public void CalculateMetric()
        {
            MetricBMI = (WeightinKG) / (HeightinMetres *2) ; 

        }
         public void CalculateImperial()
        {
            double Pounds = WeightinStones * 14;
            WeightImperial = WeightinPounds + Pounds;

            double inches = HeightinFeet * 12;
            HeightImperial = HeightinInches + inches;

            ImperialBMI = (WeightImperial * 703) / (HeightImperial * HeightImperial);
        }

        public void DisplayBMI(double BMI)
        {
            if (BMI < 18.50)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are UnderWeight");
            } 
                else if (BMI >= 18.5 && BMI <= 24.9)
                {
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.WriteLine("You are Normal");
                }
                
                else if (BMI >= 25.0 && BMI <=29.9)
                {
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.WriteLine("You are OverWeight");
                }

                else if (BMI >= 30.0 && BMI <= 34.9)
                {
                    Console.WriteLine("your BMI is " + BMI);
                    Console.WriteLine("you are in Obese Class 1");
                }

                else if (BMI >= 35.0 && BMI <= 39.9)
                {
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.WriteLine("you are in Obese Class 2");
                }

                else 
                {
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.WriteLine("you are in Obese Class 3");
                }

        }   

        public void displaybameMessage()
        {
            Console.WriteLine("If you are African, Asian or other minority ethnic groups , You have a chance to be at risk ");
            Console.WriteLine("Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more are at hight risk");
        }


    }

    
}
