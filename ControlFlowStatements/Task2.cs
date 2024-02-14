using System;

namespace ConsoleApp1.ControlFlowStatements
{
    public class Task2
    {
        public void task2()
        {
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2) Console.WriteLine("Number 1 is maximum");
            else Console.WriteLine("Number 2 is maxmimum");
        }
    }
}
