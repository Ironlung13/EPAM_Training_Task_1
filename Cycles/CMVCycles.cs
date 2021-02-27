﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Cycles.Cycles
{
    public static class CMVCycles
    {
        public static void Task1Variant6()
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

        public static void Task2Variant6()
        {
            Console.WriteLine("Formula: 1/((2n-1)*(2n+1)");
            Console.Write("Enter precision value eps:\n=> ");
            double eps;
            while (!double.TryParse(Console.ReadLine(), out eps))
            {
                Console.Write("Invalid input. Try again\n=> ");
            }

            CalculateTask2Variant6(eps);
        }

        private static void CalculateTask1Variant6(double x, double precision)
        {
            if (precision >= 1)
            {
                Console.WriteLine("Sum is 0, too small term => 1");
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
            {
                Console.WriteLine("Overflow of sum and/or xn1. Aborting.");
            }
            else
            {
                Console.WriteLine($"Sum is {sum}, too small term => {xn1}");
            }
        }

        private static void CalculateTask2Variant6(double precision)
        {
            if (precision >= (1d/3d))
            {
                Console.WriteLine("Largest single term value is 1/3. Aborting.");
                return;
            }

            double nextTerm;
            double sum = 0;
            for (ulong n = 1; (nextTerm = 1d/(2d * n - 1)/(2d * n + 1)) >= precision; n++)
            {
                sum += nextTerm;
            }
            Console.WriteLine($"Sum is {sum}, too small term => {nextTerm}");
        }
    }
}
