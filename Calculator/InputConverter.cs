using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            return double.TryParse(argTextInput, out var convertedNum)
                ? convertedNum
                : throw new ArgumentException("Expected a numeric value.");
        }
    }
}