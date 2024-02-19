using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public abstract class Work
    {
        public abstract void Member();
        public void Func()
        {
            Console.WriteLine("Function of Base class");
        }
    }

    public class work2 : Work
    {
        //can i override the method without virtual keyword

        public override void Member()
        {
            Console.WriteLine("OK");
        }
    }
}
