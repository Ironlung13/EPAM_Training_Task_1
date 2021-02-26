using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Cycles.Cycles
{
    public static class IterativeCycles
    {
        public static double CalculateIterative11(double a, double b, double precision)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The Formulae is: sin\u00b2x + 0,99cos\u00b2x - 10x = 0");
            Console.WriteLine($"Seeking answer from [{a};{b}]");
            double x0a = Function(a);
            double x0b = Function(b);
            return 0;
        }

        private static double Function(double x)
        {
            return Math.Pow(Math.Sin(x), 2d) + 0.99d * Math.Pow(Math.Cos(x), 2d) - 10 * x;
        }

        private static double FunctionFirstDerivative(double x)
        {
            return 0.02d;
        }
    }
}
