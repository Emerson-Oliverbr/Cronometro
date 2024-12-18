using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Start();
        }

        static void Start()
        {
            int time = 10, currentTime = 0 ;
             
            while(currentTime != time)
            {
                Console.Clear();
                currentTime +=1;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }           
        }         
    }
}