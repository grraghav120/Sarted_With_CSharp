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
            Console.WriteLine("Represent 1 Hour {0}",TimeSpan.FromHours(1));
            Console.WriteLine("Represent 8 Minutes {0}",TimeSpan.FromMinutes(8));
            var modifiedTime = TimeSpan.FromMinutes(8).Minutes;
            var currentTime = DateTime.Now.Minute;
            Console.WriteLine("currentTime - 8: {0}",(currentTime-modifiedTime));
        }
    }
}
