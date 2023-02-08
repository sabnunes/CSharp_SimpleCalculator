namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddTwoNumAndReturnValidResultForNonSymbolOp()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("add", num1, num2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddTwoNumAndReturnValidResultForSymbolOp()
        {
            int num1 = 2;
            int num2 = 3;
            double result = _calculatorEngine.Calculate("+", num1, num2);
            Assert.AreEqual(5, result);
        }
    }
}