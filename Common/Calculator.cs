﻿using Common.Interface;

namespace Common
{
    /// <summary>
    /// Calculator
    /// </summary>
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b; 
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
