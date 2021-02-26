using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Cycles.Cycles
{
    public static class ArithmeticCycles
    {
        public static void CalculateSum6()
        {
            Console.Write("Arithmetic Cycles (6th variant):\n=> ");

            double x;
            int k;

            Console.Write("Input value of K\n=> ");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.Write("Invalid input. Try again.\n=> ");
            }

            Console.Write("Input value of X\n=> ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input. Try again.\n=> ");
            }

            Console.WriteLine("Formula: cos(nx) / n!");
            Console.WriteLine($"The result is: {UseFormula6(k, x)}");
        }
        private static double UseFormula6(int k, double x)
        {
            double a0 = Formula6(x, 0);
            if (k == 0)
            {
                return a0;
            }

            double sum = a0;
            double aN = a0;
            for (int n = 1; n <= k; n++)
            {
                double aN1 = aN * Math.Cos((n + 1) * x) / (n + 1) / Math.Cos(n * x);
                sum += aN1;
                aN = aN1;
            }

            return sum;
        }

        private static double Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        private static double Formula6(double x, int n)
        {
            return Math.Cos(n * x) / Factorial(n);
        }
    }
}
