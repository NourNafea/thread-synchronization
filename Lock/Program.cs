for (var i = 0; i < 5; i++)
{
    new Thread(DoWork).Start();
}

Console.ReadLine();
return;

static void DoWork()
{
    lock (typeof(Program))
    {
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is working.");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done.");
    }
}