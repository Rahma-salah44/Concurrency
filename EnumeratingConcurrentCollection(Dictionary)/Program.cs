using System.Collections.Concurrent;

var stock = new ConcurrentDictionary<string, int>();
stock.TryAdd("hhh", 0);
stock.TryAdd("mm", 0);
stock.TryAdd("kk", 0);


foreach (var shirt in stock)
{
    stock["hhh"] += 1;
    Console.WriteLine(shirt.Key + ": " + shirt.Value);
}