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
            Console.WriteLine($"The answer is: {IterativeCycles.CalculateIterative6(0d, 0.3d, double.Epsilon)}");
            Console.ReadLine();
        }
    }
}
