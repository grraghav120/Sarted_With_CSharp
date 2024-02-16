using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strings
{
    public class StringExercise
    {
        public void Task1()
        {
            Console.WriteLine("Enter the Time in 24 hour:");
            var time = Console.ReadLine();
            var timeArr=time.Split(':');
            if ((Convert.ToInt32(timeArr[0])>=0 && Convert.ToInt32(timeArr[0]) <= 23) &&(Convert.ToInt32(timeArr[1])>=0 && Convert.ToInt32(timeArr[1])<=59))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
        public void Task2()
        {
            var input=Console.ReadLine(); ;
            var words=input.Split(' ');
            var result = "";
            for(int i = 0; i < words.Length; i++)
            {
                var str = "";
                var inter=words[i].ToUpper();
                str += inter[0];
                var inter1=words[i].Substring(1, words[i].Length - 1);
                str+=inter1.ToLower();
                result+= str;
            }
            Console.WriteLine(result);
        }
        public void Task3()
        {
            var input=Console.ReadLine();
            var count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a' || input[i]=='e' || input[i] =='i' || input[i]=='o' || input[i]=='u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
