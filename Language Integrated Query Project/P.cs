//1. Data source
using System.Runtime.Intrinsics.X86;

var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

//2. Query creation
var evenNumbers = numbers.Where(num => num % 2 == 0);

//3. Query execution
foreach (int num in evenNumbers)
{
    Console.WriteLine("{0,1} ", num);
}

var animals = new List<string> { "Deer", "Sheep", "Cat", "Dog", "Bull", "Donkey", "Goat" };

foreach (string animal in animals.OrderBy(animal => animal))
{
    Console.WriteLine(animal);
}

//LINQ cheat sheet
//Where()	-> Filter elements
//Select()		-> Transform elements
//OrderBy()		-> Sort ascending
//OrderByDescending()		-> Sort descending
//First()		-> Get first matching element
//FirstOrDefault()		-> Get first or default
//Single()		-> Require exactly one match
//Any()		-> Check if at least one exists
//All()		-> Check if every element matches
//Count()		-> Count elements
//Sum()		-> Calculate total
//Average()		-> Calculate average
//Max()		-> Get maximum
//Min()		-> Get minimum
//Take()		-> Take first N elements
//Skip()		-> Skip first N elements
//Distinct()		-> Remove duplicates
//GroupBy()		-> Group elements by a key
//ToList()		-> Convert results to a list
//ToArray()		-> Convert results to an array
//ToList() executes the query immediately and stores the results in a new list.


