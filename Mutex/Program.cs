var semaphore = new Semaphore(1, 1);

for (var i = 0; i < 5; i++)
{
    new Thread(Write).Start();
}
Console.ReadLine();
return;

void Write()
{
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is waiting for Writing.");
    semaphore.WaitOne();
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is writing.");
    Thread.Sleep(5000);
    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is done writing.");
    semaphore.Release();
}