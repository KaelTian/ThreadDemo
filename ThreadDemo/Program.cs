using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        //static Thread thread1, thread2;
        //static void Main(string[] args)
        //{
        //    thread1 = new Thread(ThreadProc);
        //    thread1.Name = "Thread1";
        //    thread1.Start();

        //    thread2 = new Thread(ThreadProc);
        //    thread2.Name = "Thread2";
        //    thread2.Start();

        //    Console.Read();
        //}

        //static void ThreadProc()
        //{
        //    Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        //    if (Thread.CurrentThread.Name == "Thread1" &&
        //        thread2.ThreadState != ThreadState.Unstarted)
        //    {
        //        if (thread2.Join(2000))
        //            Console.WriteLine("Thread2 has termminated.");
        //        else
        //            Console.WriteLine("The timeout has elapsed and Thread1 will resume.");
        //    }

        //    Thread.Sleep(2000);
        //    Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        //    Console.WriteLine("Thread1: {0}", thread1.ThreadState);
        //    Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
        //}



        static void Main(string[] args)
        {
            ThreadTest tt = new ThreadTest();

            new Thread(tt.Go).Start();
            tt.Go();

            Console.Read();
        }

    }
}
