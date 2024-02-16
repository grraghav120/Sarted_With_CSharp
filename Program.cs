
using ConsoleApp1.CsIntermediate;
using System;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw=new StopWatch();
            bool stopLoop = false;
            while (true)
            {
                Console.WriteLine("Press \n 1 -> Start \n 2-> Stop \n 3-> Exit");
                var input=Console.ReadLine();
                switch (input)
                {
                    case "1":
                        sw.Start();
                        Console.WriteLine("\t Started");
                        break;
                    case "2":
                        sw.Stop();
                        break;
                    default:
                        stopLoop = true;
                        break;
                }
                if (stopLoop) break;
            }
        }
    }
}