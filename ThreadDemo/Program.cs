using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static readonly int loopCount = 1000;
        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "Main Thread ... ";
            Thread t = new Thread(ThreadY);
            t.Name = "Y thread";
            t.Start();
            t.Join();
            // Console.WriteLine(Thread.CurrentThread.Name);
            //for (var i = 0; i < loopCount; i++)
            //{
            //    Console.Write("X");
            //}
            Console.WriteLine("Main Thread t has ended!");
            Console.Read();
        }



        static void ThreadY()
        {
            //Console.WriteLine(Thread.CurrentThread.Name);
            for (var i = 0; i < loopCount; i++)
            {
                Console.Write("Y");
            }
        }
    }
}
