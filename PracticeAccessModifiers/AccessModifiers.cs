using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeAccessModifiers
{
    public class A
    {
        public void funA() // public -> accessible from everywhere
        {
            Console.WriteLine("A class");
        }
        private void funB() //private -> accessible from the same class only
        {
            Console.WriteLine("B class");
        }

        public void funC()
        {
            this.funB();
        }

        protected void funD() //protected -> only the class where decalred and their derived class
        {
            Console.WriteLine("D protected Class Executed");
        }
    }

    public class B : A
    {
        public void main()
        {
            Console.WriteLine("from class B");
            this.funD();
        }
    }
    
    public class C : B
    {
        public void functions()
        {
            Console.WriteLine("From C class");
            this.funD();
        }
    }
    
    public class AccessModifiers
    {
        public void execute()
        {
            B obj = new B();
            obj.main();
            C obj1=new C();
            obj1.functions();
        }
    }

}
