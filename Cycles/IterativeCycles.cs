using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Cycles.Cycles
{
    public static class IterativeCycles
    {
        public static double CalculateIterative6(double a, double b, double precision)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The Formula is: \u221A(1-x) - tg(x) = 0");
            Console.WriteLine($"Seeking answer from [{a};{b}]");

            double xn;
            double c;
            if (Function6(a) * Function6SecondDerivative(a) > 0)
            {
                xn = b;
                c = a;
            }
            else if (Function6(b) * Function6SecondDerivative(b) > 0)
            {
                xn = a;
                c = b;
            }
            else
            {
                Console.WriteLine($"No answer for this function in [{a};{b}]");
                return -1;
            }

            double xn1;
            do
            {
                xn1 = xn - (Function6(xn) * (xn - c)) / (Function6(xn) - Function6(c));
                xn = xn1;
            }
            while (Math.Abs(Function6(xn1)) >= precision);
            return xn1;
        }

        private static double Function6(double x)
        {
            return Math.Sqrt(1d - x) - Math.Tan(x);
        }

        private static double Function6FirstDerivative(double x)
        {
            return -(1d / Math.Pow(Math.Cos(x), 2d)) - (1d / 2d / Math.Sqrt(1d - x));
        }

        private static double Function6SecondDerivative(double x)
        {
            return -2d * (Math.Sin(x) / Math.Pow(Math.Cos(x), 3)) - (1d / 4 / Math.Pow((-x + 1), 1.5d));
        }
    }
}
