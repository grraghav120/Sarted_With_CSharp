using System;
namespace ConsoleApp1.DateExercise
{
    public class DateTimeCS
    {
        public void DateExercise()
        {
            //var today=DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("Tommorrow: {0}", DateTime.Now.AddDays(1));
            Console.WriteLine("Yesterday: {0}", DateTime.Now.AddDays(-1));
        }
    }
}
