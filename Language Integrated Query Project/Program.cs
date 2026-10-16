using System;
using System.Collections.Generic;
using System.Linq;

// STEP 1: Create the buildings
List<Building> buildings = new List<Building>()
{
    new Building { Name = "Sunrise Apartments", Size = 100, TaxPerSize = 5m },
    new Building { Name = "Green Villa", Size = 200, TaxPerSize = 8m },
    new Building { Name = "City Tower", Size = 300, TaxPerSize = 10m },
    new Building { Name = "Lake House", Size = 150, TaxPerSize = 5m },
    new Building { Name = "Royal Mansion", Size = 400, TaxPerSize = 8m }
};

// STEP 2: SELECT
Console.WriteLine("=== ESTIMATED TAX PER BUILDING ===");

var estimatedTaxes = buildings.Select(b => new
{
    Name = b.Name,
    Tax = (decimal)b.Size * b.TaxPerSize
});

foreach (var item in estimatedTaxes)
{
    Console.WriteLine($"{item.Name}: £{item.Tax}");
}

// STEP 3: SUM
Console.WriteLine("\n=== TOTAL ESTIMATED TAX ===");

decimal totalTax = buildings.Sum(b =>
    (decimal)b.Size * b.TaxPerSize);

Console.WriteLine($"Total Tax: £{totalTax}");

// STEP 4: WHERE
Console.WriteLine("\n=== LARGE BUILDINGS ===");

var largeBuildings = buildings.Where(b => b.Size > 150);

foreach (var b in largeBuildings)
{
    Console.WriteLine(b.Name);
}

// STEP 5: FIRSTORDEFAULT
Console.WriteLine("\n=== FIND BUILDING ===");

Building? found = buildings.FirstOrDefault(
    b => b.Name == "City Tower");

if (found != null)
{
    Console.WriteLine($"Found: {found.Name}");
}
else
{
    Console.WriteLine("Building not found.");
}

// STEP 6: ORDERBY
Console.WriteLine("\n=== BUILDINGS SORTED BY SIZE ===");

var sortedBuildings = buildings.OrderBy(b => b.Size);

foreach (var b in sortedBuildings)
{
    Console.WriteLine($"{b.Name}: {b.Size} m²");
}

// STEP 7: GROUPBY
Console.WriteLine("\n=== BUILDINGS GROUPED BY TAX RATE ===");

var groupedBuildings = buildings.GroupBy(b => b.TaxPerSize);

foreach (var group in groupedBuildings)
{
    Console.WriteLine($"Tax Rate: {group.Key}");

    foreach (var b in group)
    {
        Console.WriteLine($" - {b.Name}");
    }
}

// STEP 8: QUERY SYNTAX EXAMPLES
Console.WriteLine("\n=== LINQ QUERY SYNTAX ===");

var queryResult =
    from b in buildings
    where b.Size > 150
    orderby b.Size
    select new
    {
        b.Name,
        b.Size
    };

foreach (var b in queryResult)
{
    Console.WriteLine($"{b.Name}: {b.Size} m²");
}