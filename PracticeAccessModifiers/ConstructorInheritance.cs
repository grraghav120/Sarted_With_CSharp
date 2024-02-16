using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeAccessModifiers
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
    }
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
    public class ConstructorInheritance
    {
        public void main()
        {
            Car car = new Car();
        }
    }
}
