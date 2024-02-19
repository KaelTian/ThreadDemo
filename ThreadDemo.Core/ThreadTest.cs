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
                Console.WriteLine($"Current time:{DateTime.Now},thread id:{Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
