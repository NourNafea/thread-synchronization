for (var i = 0; i < 5; i++)
{
    new Thread(DoWork).Start();
}

Console.ReadLine();
return;

static void DoWork()
{
    try
    {
        Monitor.Enter(typeof(Program));
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is working.");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
    finally
    {
        Monitor.Exit(typeof(Program));
    }
}