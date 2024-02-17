
using ConsoleApp1.ArrayExercise;
using ConsoleApp1.CsIntermediate;
using ConsoleApp1.PolymorphismExercise;
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

            //string input= Console.ReadLine();
            //string[] arrInput = input.Split(' ');
            //List<int> arr=new List<int>();
            //for(int i=0;i<arrInput.Length;i++)
            //{
            //    arr.Add(int.Parse(arrInput[i]));
            //}
            //int key = Convert.ToInt32(Console.ReadLine());
            //Search search = new Search();
            //Console.WriteLine(search.BinarySearch(arr,key));

            //LowerTraingularMatrix matrix = new LowerTraingularMatrix();
            //matrix.Fun();

            //SumOfDiagonals sumOfDiagonals = new SumOfDiagonals();
            //sumOfDiagonals.Sum();

            //DesignStack stack = new DesignStack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //PolyMophism polyMophism = new PolyMophism();
            //polyMophism.Draw();
            //PolymorphismExercise.B obj = new PolymorphismExercise.B();
            //obj.Draw();

            //OracleConnection sqlConnection = new OracleConnection("");
            //sqlConnection.openConnection();
            //sqlConnection.closeConnection();

            DbCommand dbCommand = new DbCommand(new SqlConnection("MyConnectionString"), "T-SQLCommand");
            dbCommand.Execute();
        }
    }
}