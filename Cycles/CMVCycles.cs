using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Cycles.Cycles
{
    public static class CMVCycles
    {
        public static void CMVCylesTask1Variant6()
        {
            Console.WriteLine("Formula: E = x^n/n!");
            Console.Write("Enter value of X:\n=> ");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input. Try again\n=> ");
            }

            Console.Write("Enter precision value eps:\n=> ");
            double eps;
            while(!double.TryParse(Console.ReadLine(), out eps))
            {
                Console.Write("Invalid input. Try again\n=> ");
            }

            CalculateTask1Variant6(x, eps);
        }

        private static double CalculateTask1Variant6(double x, double precision)
        {
            if (precision >= 1)
            {
                return 0d;
            }

            double sum = 1;
            double xn = 1;
            double xn1;
            for (ulong n = 0; Math.Abs((xn1 = xn * x / (n + 1))) >= precision && !double.IsInfinity(xn1); n++)
            {
                sum += xn1;
                xn = xn1;
            }

            if (double.IsInfinity(xn1))
                Console.WriteLine("Overflow of sum and/or xn1. Aborting.");
            else
                Console.WriteLine($"Sum is {sum}, too small term => {xn1}");
            return sum;
        }
    }
}
