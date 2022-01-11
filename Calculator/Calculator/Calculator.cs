using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }

        public string Add()
        {
            return Convert.ToString(Convert.ToDouble(FirstNumber) + Convert.ToDouble(SecondNumber));
        }
        public string Multi()
        {
            return Convert.ToString(Convert.ToDouble(FirstNumber) * Convert.ToDouble(SecondNumber));
        }
        public string Divide()
        {
            if (FirstNumber == "0") {
                return "0";
            } else if (SecondNumber == "0") {
                return "error";
            } else
            {
                return Convert.ToString(Convert.ToDouble(FirstNumber) / Convert.ToDouble(SecondNumber));
            }
        }
    }
}