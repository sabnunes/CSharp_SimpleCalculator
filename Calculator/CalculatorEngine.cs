using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNum, double argSecondNum)
        {
            double result;
            switch(argOperation.ToLower())
            {
                case "sum":
                case "add":
                case "plus":
                case "+":
                    result = argFirstNum + argSecondNum;
                    break;
                case "subtract":
                case "minus":
                case "-":
                    result = argFirstNum - argSecondNum;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNum * argSecondNum;
                    break;
                case "divide":
                case "/":
                    result = argFirstNum / argSecondNum;
                    break;
                default:
                    throw new InvalidOperationException("Operation is not recognized.");
            }
            return result;
        }
    }
}
