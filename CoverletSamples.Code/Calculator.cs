using System;

namespace CoverletSamples.Code
{
    public static class Calculator
    {
        public static int Sum(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;
        public static int Power(int a, int power) => (int)Math.Pow(a, power);

        public static int Divide(int a, int b)
        {
            if (b == 0) throw new InvalidOperationException("The second part of the division cannot be 0");
            return a / b;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsPrime(int a)
        {
            for (var n = 2; n <= Math.Sqrt(a); n++)
            {
                if (a % n == 0) return false;
            }
            return true;
        }

        // public static int DoSomeVeryLongCalculation(int a)
        // {
        //     if (IsPrime(a))
        //     {
        //         return a;
        //     }

        //     if (IsEven(a))
        //     {
        //         a = Sum(a, a);
        //     }

        //     a = Multiply(a, a);
        //     a = Power(a, a);

        //     if (!IsEven(a))
        //     {
        //         a = Subtract(a, a);
        //     }

        //     return a;
        // }
    }
}