﻿namespace UnitTestsExample
{
    public class Calc
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2; // earlier try intentionally: num1 / num2
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
