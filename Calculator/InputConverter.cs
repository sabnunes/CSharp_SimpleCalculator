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
            double convertedNum;
            if (!double.TryParse(argTextInput, out convertedNum)) throw new ArgumentException("Expected a numeric value.");
            return convertedNum;
        }
    }
}
