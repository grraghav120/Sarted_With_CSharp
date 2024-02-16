using System;

namespace ConsoleApp1.CsIntermediate
{
    internal class StopWatch
    {
        private DateTime _interval;
        private bool startStopWatch = false;
        public void Start() {
            if (startStopWatch)
            {
                throw new InvalidOperationException("Already Started Please First Stop the Watch:");
            }
            else {
                _interval = DateTime.Now;
                startStopWatch = true;
            }
        }
        public void Stop() {
            if (startStopWatch)
            {
                startStopWatch = false;
                var currentTime = DateTime.Now;
                var diff = currentTime - _interval;
                Console.WriteLine("\t Lap Recorded at {0}", diff);
            }
            else
            {
                throw new InvalidOperationException("Already Stop Watched.");
            }
            
        } 
    }

    public class StopWatchExcexute
    {
        public void execute()
        {
            StopWatch sw =new StopWatch();
            bool stopLoop = false;
            while (true)
            {
                Console.WriteLine("Press \n 1 -> Start \n 2-> Stop \n 3-> Exit");
                var input = Console.ReadLine();
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
