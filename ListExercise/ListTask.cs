using System;
using System.Collections.Generic;

namespace ConsoleApp1.ListExercise
{
    public class ListTask
    {
        public void Task1()
        {
            var likeByPeople=new List<string>();
            while (true)
            {
                var input=Console.ReadLine();
                if(input=="")
                {
                    break;
                }
                else
                {
                    likeByPeople.Add(input);
                }
            }
            int numberOFLikes = likeByPeople.Count;
            if (numberOFLikes == 0) { }
            else if(numberOFLikes == 1)
            {
                Console.WriteLine("{0} likes your post.",likeByPeople[0]);
            }
            else if (numberOFLikes == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", likeByPeople[0], likeByPeople[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", likeByPeople[0], likeByPeople[1], numberOFLikes - 2);
            }
 
        }

        public void Task2()
        {
            var name = Console.ReadLine();
            var sizeOfName = (int)name?.Length;
            var array = new char[sizeOfName];
            var reversedString = "";
            for (int i = 0; i < sizeOfName; i++)
            {
                array[i] = name[i];
            }
            Array.Reverse(array);
            for (int i = 0; i < sizeOfName; i++)
            {
                reversedString += array[i];
            }
            Console.WriteLine(reversedString);
        }
    
        public void Task3()
        {
            Console.WriteLine("Enter 5 unique numbers: ");
            var arr = new List<int>();
            var i = 0;
            while (i < 5)
            {
                var input=Convert.ToInt32(Console.ReadLine());
                if(arr.IndexOf(input) == -1)
                {
                    arr.Add(input);
                    i++;
                }
                else
                {
                    Console.WriteLine("Already Exist number please enter unique: ");
                }
                
            }
            arr.Sort();
            for (int j = 0; j < arr.Count; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }

        public void Task5()
        {
            var input=Console.ReadLine();
            var arrOfNumbers=input.Split(',');
            if(arrOfNumbers.Length < 5)
            {
                Console.WriteLine("Invalid List.Please ReTry.!");
            }
            else
            {
                Array.Sort(arrOfNumbers);
                Console.WriteLine("{0},{1},{2}", arrOfNumbers[0], arrOfNumbers[1], arrOfNumbers[2]);
            }
        }
    }
}
