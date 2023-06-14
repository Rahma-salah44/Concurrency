static int GetSquareNumber(int number)
{
    Thread.Sleep(3000);
    return number * number;
}

// main thread
var result = 0;

// create a new task (in a different thread)
var task = Task.Run(() => GetSquareNumber(10));

// create a continuation
task.ContinueWith((task) =>
{
    // a different thread
    result = task.Result;
    result = task.Result;
    Console.WriteLine($"Result:{result}");
});


while (result == 0)
{
    Console.WriteLine("Waiting for the result...");
    Thread.Sleep(1000);
}
