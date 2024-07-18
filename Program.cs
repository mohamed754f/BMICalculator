namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMICalculator<double> calculator = new BMICalculator<double>();

            while (true)
            {
                Console.WriteLine("Enter height in meters : ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter weight in kilograms : ");
                double weight = double.Parse(Console.ReadLine());

                double bmi = calculator.CalculateBMI(weight, height);
                string category = calculator.GetBMICategory(bmi);

                Console.WriteLine($"Your BMI is {bmi:F2} and you are {category}.");

                calculator.StoreBMIResult(bmi, category);

                Console.WriteLine("Do you want to see previous bmi calculations? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    calculator.DisplayPreviousResults();
                }

                Console.WriteLine("Do you want to calculate another bmi? ( yes/no )");
                response = Console.ReadLine().ToLower();

                if (response == "n")
                {
                    break;
                }
            }
        }
    }
}

