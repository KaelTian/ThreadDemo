using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class ThreadTest
    {
        private bool _done;


        public void Go()
        {
            if (!_done)
            {
                _done = true;
                Console.WriteLine("Done!");
            }
        }
    }
}
