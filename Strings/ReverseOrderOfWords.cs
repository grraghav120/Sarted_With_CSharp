using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strings
{
    internal class ReverseOrderOfWords
    {
        public void ReverseOrder()
        {
            string input=Console.ReadLine();
            string[] words = input.Split(' ');
            Array.Reverse(words);
            StringBuilder res=new StringBuilder();
            int i = 0;
            for(i = 0; i < words.Length-1; i++)
            {
                res.Append(words[i]);
                res.Append(" ");
            }
            res.Append(words[i]);
            Console.WriteLine(res);
        }
    }
}
