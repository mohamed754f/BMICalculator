using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BMICalculator<T> where T : struct, IConvertible
    {
        private List<BMIResult> bmiResults = new List<BMIResult>();

        public double CalculateBMI(T weight, T height)
        {
            double weightValue = Convert.ToDouble(weight);
            double heightValue = Convert.ToDouble(height);

            return weightValue / (heightValue * heightValue);
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "under weight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                return "over weight";
            }
            else
            {
                return "obesty";
            }
        }

        public void StoreBMIResult(double bmi, string category)
        {
            bmiResults.Add(new BMIResult { BMIValue = bmi, Category = category });
        }

        public void DisplayPreviousResults()
        {
            Console.WriteLine("previous bmi calculations:");
            foreach (var result in bmiResults)
            {
                Console.WriteLine($"bmi : {result.BMIValue}, category: {result.Category}");
            }
        }
    }

}