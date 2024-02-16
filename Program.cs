
using ConsoleApp1.ArrayExercise;
using ConsoleApp1.CsIntermediate;
using ConsoleApp1.PracticeAccessModifiers;
using System;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {
            //StopWatchExcexute swe= new StopWatchExcexute();
            //swe.execute();

            //Accessible access = new Accessible();
            //access.MainAccessible();

            //AccessModifiers obj=new AccessModifiers();
            //obj.execute();

            string input= Console.ReadLine();
            string[] arrInput = input.Split(' ');
            List<int> arr=new List<int>();
            for(int i=0;i<arrInput.Length;i++)
            {
                arr.Add(int.Parse(arrInput[i]));
            }
            int key = Convert.ToInt32(Console.ReadLine());
            Search search = new Search();
            Console.WriteLine(search.BinarySearch(arr,key));

        }
    }
}