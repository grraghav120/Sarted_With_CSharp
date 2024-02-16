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
            startStopWatch = false;
            var currentTime=DateTime.Now;
            var diff=currentTime - _interval;
            Console.WriteLine("\t Lap Recorded at {0}",diff);
        } 
    }
}
