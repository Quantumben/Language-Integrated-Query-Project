//1. Data source
var numbers = new List<int> {0, 1, 2, 3,4,5,6 };

//2. Query creation
var evenNumbers = numbers.Where(num => num % 2 == 0);

//3. Query execution
foreach(int num in evenNumbers)
{
    Console.WriteLine("{0,1} ", num);
}

var animals = new List<string> {"Deer", "Sheep", "Cat", "Dog", "Bull", "Donkey", "Goat"};

foreach(string animal in animals.OrderBy(animal => animal))
{
    Console.WriteLine(animal);
}