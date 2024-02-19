using ThreadDemo;

ThreadTest tt = new ThreadTest();

new Thread(tt.Go).Start();
tt.Go();

Console.Read();