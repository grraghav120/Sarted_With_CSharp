using System;

namespace ConsoleApp1.Constructors
{
    public class PracticeExercise
    {
        public PracticeExercise()
        {
            Console.WriteLine("Default Constructor");
        }
        public PracticeExercise(string name)
        {
            Console.WriteLine("One Parameter Constructor {0}", name);
        }
        public PracticeExercise(int a,int b)
        {
            Console.WriteLine("2 paramters constructor {0}", a + b);
        }
        public PracticeExercise(string fName,string lName,string mName)
        {
            Console.WriteLine("3 Parameters Constructor {0}",fName+mName+lName);
            
        }
    }
}
