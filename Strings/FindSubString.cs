using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strings
{
    internal class FindSubString
    {
        public void Substrings()
        {
            string input = Console.ReadLine();
            int len = input.Length;
            List<string> substrings = new List<string>();
            for(int i = 0; i < len; i++)
            {
                for(int j=i; j < len; j++)
                {
                    string sub=input.Substring(i,j-i+1);
                    substrings.Add(sub);
                }
            }
            foreach(string sub in substrings)
            {
                Console.Write(sub+" ");
            }
        }
    }
}
