using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebApplicationNetFramework.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAddition()
        {
            double result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result, "Adding 2 and 3 should return 5.");
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double result = Calculator.Subtract(5, 3);
            Assert.AreEqual(2, result, "Subtracting 3 from 5 should return 2.");
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double result = Calculator.Multiply(3, 4);
            Assert.AreEqual(12, result, "Multiplying 3 and 4 should return 12.");
        }

        [TestMethod]
        public void TestDivision()
        {
            double result = Calculator.Divide(10, 2);
            Assert.AreEqual(5, result, "Dividing 10 by 2 should return 5.");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            // This should throw a DivideByZeroException
            Calculator.Divide(10, 0);
        }

        [TestMethod]
        public void TestModulo()
        {
            double result = Calculator.Modulo(10, 3);
            Assert.AreEqual(1, result, "The modulo of 10 and 3 should return 1.");
        }

        [TestMethod]
        public void TestPower()
        {
            double result = Calculator.Power(2, 3);
            Assert.AreEqual(8, result, "2 raised to the power of 3 should return 8.");
        }
        [TestMethod]
        public void TestSquareRoot()
        {
            double result = Calculator.SquareRoot(16);
            Assert.AreEqual(4, result, "The square root of 16 should return 4.");
        }
    }
}
