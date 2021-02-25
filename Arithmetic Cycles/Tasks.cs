using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Training_Task_1.Arithmetic_Cycles
{
    public class Tasks
    {
        private Dictionary<int, Func<int, double, double>> taskDictionary = new Dictionary<int, Func<int, double, double>>();
        public Dictionary<int, Func<int, double, double>> TaskDictionary { get => taskDictionary; }

        public Tasks()
        {
            taskDictionary.Add(1, CalculateSum1);
            taskDictionary.Add(2, CalculateSum2);
            taskDictionary.Add(3, CalculateSum3);
            taskDictionary.Add(4, CalculateSum4);
            taskDictionary.Add(5, CalculateSum5);
            taskDictionary.Add(6, CalculateSum6);
            taskDictionary.Add(7, CalculateSum7);
            taskDictionary.Add(8, CalculateSum8);
            taskDictionary.Add(9, CalculateSum9);
            taskDictionary.Add(10, CalculateSum10);
        }

        private double CalculateSum1(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += (Math.Pow(Math.Log(3), n) * Math.Pow(x, n)) / Factorial(n);
            }

            return sum;
        }

        private double CalculateSum2(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow(-1d, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
            }

            return sum;
        }

        private double CalculateSum3(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow(x, n) / Factorial(n);
            }

            return sum;
        }

        private double CalculateSum4(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Cos(n * Math.PI / 4) * Math.Pow(x, n) / Factorial(n);
            }

            return sum;
        }

        private double CalculateSum5(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            }

            return sum;
        }

        private double CalculateSum6(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Cos(x * n) / Factorial(n);
            }

            return sum;
        }

        private double CalculateSum7(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += (2 * n + 1) * Math.Pow(x, 2 * n) / Factorial(n);
            }

            return sum;
        }

        private double CalculateSum8(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow((x - 1) / (x + 1), 2 * n + 1) / (2 * n + 1);
            }

            return sum;
        }

        private double CalculateSum9(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow(-1, n + 1) * Math.Pow(x, 2 * n + 1) / (4 * Math.Pow(n, 2) - 1);
            }

            return sum;
        }

        private double CalculateSum10(int k, double x)
        {
            double sum = 0;
            for (int n = 0; n <= k; n++)
            {
                sum += Math.Pow(x, 2 * n) / Factorial(2 * n);
            }

            return sum;
        }
        private static int Factorial(int n)
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
    }
}
