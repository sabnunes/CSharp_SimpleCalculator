using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            return double.TryParse(argTextInput, out var convertedNum) ? convertedNum : throw new ArgumentException("Expected a numeric value.");
        }
    }
}
