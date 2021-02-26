using System;
using LabWork_Cycles.Cycles;

namespace LabWork_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, User!");
            Console.WriteLine("Choose cycle type to test:");
            Console.WriteLine("1: Arithmetic Cycles.");
            Console.WriteLine("2: Iterative Cycles.");
            ProgramChoice:
            switch (Console.ReadLine())
            {
                case "1":
                    ArithmeticCycles.CalculateSum6();
                    break;
                case "2":
                    IterativeCycles.CalculateIterative6();
                    break;
                default:
                    Console.Write("Invalid input. Try again\n=> ");
                    goto ProgramChoice;
            }
            Console.ReadLine();
        }
    }
}
