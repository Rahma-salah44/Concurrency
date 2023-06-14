async Task<int> MyAsyncMethodAsync()
{
    // Do some asynchronous work here
    await Task.Delay(1000); // Wait for 1 second

    // Return a result
    return 42;
}



Console.WriteLine(await MyAsyncMethodAsync());
