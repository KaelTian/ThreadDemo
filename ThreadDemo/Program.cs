using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static Thread thread1, thread2;
        static void Main(string[] args)
        {
            thread1 = new Thread(ThreadProc);
            thread1.Name = "Thread1";
            thread1.Start();

            thread2 = new Thread(ThreadProc);
            thread2.Name = "Thread2";
            thread1.Start();
        }

        static void ThreadProc()
        {

        }

    }
}
