using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strings
{
    internal class Palindrome
    {
        public void isPalindrome()
        {
            string input=Console.ReadLine();
            bool isPalindromeString = false;
            int n = input.Length;
            for(int i = 0; i < n / 2; i++)
            {
                if (input[i] != input[n-1-i]) { 
                    isPalindromeString = true;
                    break;
                }
            }
            if(isPalindromeString) { Console.WriteLine("Not a Palindrome"); }
            else { Console.WriteLine("Palindrome String"); }
        }
    }
}
