int counter = 0;

void Increase()
{
    for (int i = 0; i < 1000000; i++)
    {
        Interlocked.Increment(ref counter);

    }
    Console.WriteLine("The counter is " + counter);
}

Task.Run(() => Increase());
Task.Run(() => Increase());

Console.ReadLine();