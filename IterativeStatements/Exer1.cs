
using System;

namespace ConsoleApp1.IterativeStatements
{
    public class Exer1
    {
        public void exercise1()
        {
            int count = 0;
            for(int i = 1; i < 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine(count);
        }
        public void exercise2()
        {
            int sum = 0;
            while(true)
            {
                var input=Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
            }
            Console.WriteLine(sum);
        }
        public void exercise3()
        {
            int num1=Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i = num1; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        public void exercise4() {
            Random random = new Random();
            int secretNumber = random.Next(1,10);
            int chances = 4, flag=0 ;
            while (chances > 0)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if(input==secretNumber)
                {
                    Console.WriteLine("You Won");
                    flag = 1;
                    break;
                }
                chances--;
            }
            if (flag==0)
            {
                Console.WriteLine("Secret Number is {0} ", secretNumber);
                Console.WriteLine("You Lost");
            }
        }

        public void exercise5()
        {
            var input= Console.ReadLine();
            int maxi = 0;
            //Console.WriteLine(input);
            for(int i = 1; i < input.Length-1; i++)
            {
                Console.WriteLine(input[i]);
                if (input[i] != ',') {
                    if (Convert.ToInt32(input[i])>maxi) {
                        maxi = Convert.ToInt32(input[i]);
                    }
                }
            }
            Console.WriteLine(maxi);
        }

    }
}
