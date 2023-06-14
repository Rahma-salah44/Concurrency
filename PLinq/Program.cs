//Creating a Collection of integer numbers
var numbers = Enumerable.Range(1, 20);

//Fetching the List of Even Numbers using PLINQ
//PLINQ means we need to use AsParallel()
var evenNumbers = numbers
    .AsParallel() //Parallel Processing
    .AsOrdered() //Original Order of the numbers
    .Where(x => x % 2 == 0)
    .ToList();
Console.WriteLine("Even Numbers Between 1 and 20");
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.ReadKey();