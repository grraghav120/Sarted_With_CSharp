using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment
{
    public class Calculator
    {
        private int _result;

        public int UpdateResultValue
        {
            get { return _result; }
            set { _result = value; }
        }

        public int  Add(int num1,int num2)
        {
             int val= num1 + num2;
            _result = val;
            return val;
        }
        public int Add(int num1,int num2,int num3) {
            int val = num1 + num2 + num3;
            _result = val;
            return val;
        }
        public float Add(float num1,float num2)
        {
            float val = num1 + num2;
            _result = (int) (num1+num2);
            return val;
        }
        public virtual int GetResult()
        {
            return _result;
        }
    }

    public class AdvancedCalculator : Calculator
    {
        public double Power(int baseVal,int exponentVal)
        {
            double value= Math.Pow(baseVal, exponentVal);
            UpdateResultValue = (int) value;
            return value;
        }

        public override int GetResult()
        {
            int result = UpdateResultValue;
            result = result * (int)(10e6);
            return result;
        }
    }
}
