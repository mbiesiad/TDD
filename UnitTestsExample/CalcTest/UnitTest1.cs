using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsExample;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            Calc calc = new Calc();
            double result = calc.Add(15, 15);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            Calc calc = new Calc();
            double result = calc.Subtract(15, 15);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Test_Divide()
        {
            Calc calc = new Calc();
            double result = calc.Divide(15, 5);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            Calc calc = new Calc();
            double result = calc.Multiply(15, 15);
            Assert.AreEqual(result, 225);
        }
        [TestMethod]
        public void TestMethod1()
        {
            // A test method's requirements:
            // -the method must be defined with the[TestMethod] attribute just above method name!
            // -can't have any parameters
            // -must having return type void
        }
    }
}
