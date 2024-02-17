using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PolymorphismExercise
{
    public class PolyMophism
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw Function of Base Class");
        }
    }

    public class B : PolyMophism
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw fucntion of Child B class");
        }
    }
}
