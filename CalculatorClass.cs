
//Create a Calculator class. 
//It should support a method Add which returns the sum of :
//2 integers
//3 integers
//2 floating point numbers
//There should be a private field named Result which holds the result of the latest operation performed.
//There should be a method GetResult which returns the result.

//Derive AdvancedCalculator class from Calculator.
//It should support a method Power which takes 2 integer parameters - base and exponent, and return the result of the operation. It should also update the Result property.
//Override the GetResult method to return the result in micros (multiply result by 10^6)

//Instantiate the above classes and call the different functions.

//Note: Use interfaces for the above classes as applicable

using System;

namespace ConsoleApp1
{
    public interface ICalculator
    {
        int Add(int num1, int num2);
        int Add(int num1, int num2, int num3);
        float Add(float num1, float num2);
    }

    public interface IOperations
    {
        float Power(int basVal, int exponentVal);
    }
    public class CalculatorClass:ICalculator
    {
        private float _result;

        // Create a property to access the private variable
        public float UpdateResult
        {
            get { return _result; }
            set { _result = value; }
        }

        public int Add(int num1,int num2)
        {
            _result = num1 + num2;            
            return (int)_result;
        }
        public float Add(float num1, float num2)
        {
            _result= num1 + num2;
            return (float)_result;
        }
        public int Add(int num1,int num2,int num3)
        {
            _result = num1 + num2 + num3;
            return (int)(_result);
        }
        public virtual float GetResult()
        {
            return _result;
        }
    }

    public class AdvancedCalculatorClass : CalculatorClass, IOperations
    {
        public float Power(int baseVal,int exponentVal)
        {
            float result = (float) Math.Pow(baseVal, exponentVal);
            UpdateResult = result;
            return UpdateResult;
        }

        public override float GetResult()
        {
            return  UpdateResult * (1e6f);
        }

    }
}
