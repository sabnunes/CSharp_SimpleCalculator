using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine(
                    "This program will run basic calculator operations with the input of two numerical inputs and one operator.\n\nEnter the 1st number: ");
                double n1 = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number: ");
                double n2 = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter the operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, n1, n2);
                Console.WriteLine("The result of {0} {1} {2} is {3}\n", n1, operation, n2, result);

                Console.WriteLine("Enter any key to close the console.");
                string anyKey = Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Should be logged
                Console.WriteLine(ex.Message);
            }
        }
    }
}