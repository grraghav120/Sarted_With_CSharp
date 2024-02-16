using System;

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
