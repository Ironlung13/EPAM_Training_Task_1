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
            Console.WriteLine("3: CMV Cycles Task 1.");
            Console.WriteLine("4: CMV Cycles Task 2.");
            Console.WriteLine("5: CMV Cycles Task 3.");
            Console.Write("\n=> ");
            ProgramChoice:
            switch (Console.ReadLine())
            {
                case "1":
                    ArithmeticCycles.CalculateSum6();
                    break;
                case "2":
                    IterativeCycles.CalculateIterative6();
                    break;
                case "3":
                    CMVCycles.Task_1_Variant6();
                    break;
                case "4":
                    CMVCycles.Task_2_Variant6();
                    break;
                case "5":
                    CMVCycles.Task_3_Variant6();
                    break;
                default:
                    Console.Write("Invalid input. Try again\n=> ");
                    goto ProgramChoice;
            }
            Console.ReadLine();
        }
    }
}
