List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Zetna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Zardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
IEnumerable<Eruption> firstEruptionInChile = eruptions.Where(chile => chile.Location == "Chile");
Eruption? firstEruptionInHI = eruptions.FirstOrDefault(hawaii => hawaii.Location == "Hawaiian Is");
Eruption? firstAfter1900AndNZ = eruptions.First(n => n.Year > 1900 && n.Location.Contains("New Zealand"));
IEnumerable<Eruption> allEruptionOver2000M = eruptions.Where(meter => meter.ElevationInMeters > 2000);
IEnumerable<Eruption> allEruptionWithZ = eruptions.Where(a => a.Volcano.Contains("Z"));
int? highestElevation = eruptions.Max(highest => highest.ElevationInMeters);
Eruption? nameOfHighestElevation = eruptions.FirstOrDefault(v => v.ElevationInMeters == highestElevation);
IEnumerable<Eruption> allEruptionsAToZ = eruptions.OrderBy(name => name.Volcano);
IEnumerable<Eruption> allEruptionsBeforeAToZ = eruptions.Where(b => b.Year < 1000).OrderBy(b => b.Volcano);
//1.
// Console.WriteLine(firstEruptionInChile.First());
//2.
// if (firstEruptionInHI != null)
// {
//     Console.WriteLine(firstEruptionInHI);
// } else
// {
//     Console.WriteLine("No Hawaiian Is eruption found.");
// }
// 3.
// Console.WriteLine(firstAfter1900AndNZ);
// 4.
// foreach (Eruption a in allEruptionOver2000M)
// {
//     Console.WriteLine(a);
// }
// 5.
// int volcanoCount = 0;
// foreach (Eruption i in allEruptionWithZ)
// {
//     volcanoCount++;
//     Console.WriteLine(i);
//     Console.WriteLine(volcanoCount);
// }
// 6.
// Console.WriteLine(highestElevation);
// 7.
// Console.WriteLine(nameOfHighestElevation.Volcano);
// 8.
// foreach (Eruption a in allEruptionsAToZ)
// {
//     Console.WriteLine(a.Volcano);
// }
// 9.
foreach (Eruption z in allEruptionsBeforeAToZ)
{
    Console.WriteLine(z.Volcano);
}


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }

