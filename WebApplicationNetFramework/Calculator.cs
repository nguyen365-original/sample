using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNetFramework
{
    public static class Calculator
    {
        // Adds two numbers.
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Subtracts the second number from the first.
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplies two numbers.
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divides the first number by the second.
        // Throws a DivideByZeroException if the second number is zero.
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return a / b;
        }

        // Returns the remainder of the division of a by b.
        public static double Modulo(double a, double b)
        {
            return a % b;
        }

        // Raises a number to the power of the given exponent.
        public static double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }
    }
}