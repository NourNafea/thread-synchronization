var manualResetEvent = new ManualResetEvent(false);

new Thread(Write).Start();

for (var i = 0; i < 5; i++)
{
    new Thread(Read).Start();
}

Console.ReadLine();
return;

void Write()
{
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is waiting for Writing.");
    manualResetEvent.Reset();
    Thread.Sleep(5000);
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done writing.");
    manualResetEvent.Set();
}

void Read()
{
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is waiting for reading.");
    manualResetEvent.WaitOne();
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done reading.");
}