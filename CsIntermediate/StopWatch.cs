using System;

namespace ConsoleApp1.CsIntermediate
{
    internal class StopWatch
    {
        private DateTime _interval;
        public void Start() {
            _interval = DateTime.Now;
        }
        public void Stop() {

            var currentTime=DateTime.Now;
            var diff=currentTime - _interval;
            Console.WriteLine("\t Lap Recorded at {0}",diff);
        } 
    }
}
