var autoResetEvent = new AutoResetEvent(true);

for (var i = 0; i < 5; i++)
{
    new Thread(Write).Start();
}

Thread.Sleep(3000);
autoResetEvent.Set();
Console.ReadLine();
return;

void Write()
{
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is waiting for Writing.");
    autoResetEvent.WaitOne();
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is writing.");
    Thread.Sleep(5000);
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done writing.");
    autoResetEvent.Set();
}