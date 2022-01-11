using System;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public string[] Numbers { get; set; }

        public string Add()
        {
            string sum = "0";
            foreach (string number in Numbers)
            {
                sum = Convert.ToString(Convert.ToDouble(sum) + Convert.ToDouble(number));
            }
            return sum;
        }
        public string Multi()
        {
            string sum = "1";
            foreach (string number in Numbers)
            {
                sum = Convert.ToString(Convert.ToDouble(sum) * Convert.ToDouble(number));
            }
            return sum;
        }
        public string Divide()
        {
            string sum = Numbers.First();
            foreach (string number in Numbers.Skip(1).ToArray())
            {
                if (sum == "0")
                {
                    return "0";
                }
                else if (number == "0")
                {
                    return "error";
                }
                else
                {
                    sum = Convert.ToString(Convert.ToDouble(sum) / Convert.ToDouble(number));
                }
            }
            return sum;
        }
    }
}