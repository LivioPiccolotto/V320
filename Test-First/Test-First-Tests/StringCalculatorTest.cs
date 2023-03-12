using NuGet.Frameworks;
using Test_First;

namespace Test_First_Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var calc = new StringCalculator();

            var res = calc.Add("1,4");

            Assert.AreEqual(5, res);
        }

        
        public void Add_ShouldIncreaseCalledCount()
        {
            StringCalculator calculator = new StringCalculator();
            int expectedCalledCount = 3;

            calculator.Add("1,2,3");
            calculator.Add("4,5,6");
            calculator.Add("7,8,9");

            Assert.AreEqual(expectedCalledCount, calculator.CalledCount);
        }
    }
}