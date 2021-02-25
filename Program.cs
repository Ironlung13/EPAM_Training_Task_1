using System;
using EPAM_Training_Task_1.Arithmetic_Cycles;

namespace EPAM_Training_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

        EntryPoint:
            Console.Write("Choose desired calculation formula (range: 1-10): ");
            int taskNumber = 0;
            while (int.TryParse(Console.ReadLine(), out taskNumber) == false ||
                   taskNumber > tasks.TaskDictionary.Count || taskNumber < 1)
            {
                Console.WriteLine("Invalid input, try again");
            }

            var method = tasks.TaskDictionary[taskNumber];
            double x = 0;
            int k = 0;
            Console.WriteLine($"You've chosen task number {taskNumber}.");

            Console.WriteLine("Enter your X value (floating point number):");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input of X, try again");
            }

            Console.WriteLine("Enter your K value (positive integer):");
            while (!int.TryParse(Console.ReadLine(), out k) || k < 1)
            {
                Console.WriteLine("Invalid input of K, try again");
            }

            Console.WriteLine("The Sum is: {0}", method.Invoke(k, x));
            Console.ReadLine();
            Console.Clear();
            goto EntryPoint;
        }
    }
}
