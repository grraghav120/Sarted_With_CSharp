
using ConsoleApp1.CsIntermediate;
using System;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {
            //StopWatch sw=new StopWatch();
            bool stopLoop = false;
            //while (true)
            //{
            //    Console.WriteLine("Press \n 1 -> Start \n 2-> Stop \n 3-> Exit");
            //    var input=Console.ReadLine();
            //    switch (input)
            //    {
            //        case "1":
            //            sw.Start();
            //            Console.WriteLine("\t Started");
            //            break;
            //        case "2":
            //            sw.Stop();
            //            break;
            //        default:
            //            stopLoop = true;
            //            break;
            //    }
            //    if (stopLoop) break;
            //}

            Post post = new Post("newPost","Description",DateTime.Now);
            while (true)
            {
                Console.WriteLine("Press \n 1-> Upvote \n 2-> Downvote \n 3-> Get the number of votes");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        post.SetVotes(true);
                        break;
                    case "2":
                        post.SetVotes(false);
                        break;
                    case "3":
                        Console.WriteLine("Number of Current Vote on this post is {0}",post.Vote);
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