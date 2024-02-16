using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strings
{
    public class ReverseString
    {
        public void Reverse()
        {
            string input=Console.ReadLine();
            int len = input.Length;
            string result = "";
            for(int i=len-1; i>=0; i--) {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
