using System;
namespace ConsoleApp1.ControlFlowStatements
{
    public class Task1
    {
        public void task()
        {
            int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1);
            if(num1>=1 && num1 <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("InValid");
            }
        }
    }
}
