﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        public int Multiply(int multiplyA, int multiplyB)
        {
            return multiplyA * multiplyB;
        }
        public int Division(int divisionA, int divisionB)
        {
            return divisionA / divisionB;
        }
    }
}
