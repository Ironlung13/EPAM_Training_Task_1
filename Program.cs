using System;
using EPAM_Training_Task_1.Arithmetic_Cycles;

namespace EPAM_Training_Task_1
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"The result is: {ArithmeticCycles.CalculateSum6(k, x)}");
        }
    }
}
