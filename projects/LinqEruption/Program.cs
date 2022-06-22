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
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// 1. First Eruption in Chilie
// IEnumerable<Eruption> firstEruptionInChile = eruptions.Where(fe => fe.Location == "Chile").OrderBy(y => y.Year).Take(1);
// PrintEach(firstEruptionInChile, "The First Eruption in Chile.");
// 2. First Eruption in "Hawaiian Is" with error if none found
// Eruption? firstEruptionInHawaiianIs = eruptions.FirstOrDefault(fe => fe.Location == "Hawaiian Is");
// if(firstEruptionInHawaiianIs == null)
// {
//     Console.WriteLine("No Hawaiian Is Eruption found");
// }else
// {
//     Console.WriteLine(firstEruptionInHawaiianIs.ToString());
// }
// 3. first eruption after Year 1900 and in New Zealand
// Eruption? newZealandEruption1900 = eruptions.FirstOrDefault(fe => fe.Location == "New Zealand" &&  fe.Year > 1900);
// if(newZealandEruption1900 == null)
// {
//     Console.WriteLine("No Eruption found");
// }else
// {
//     Console.WriteLine(newZealandEruption1900.ToString());
// }
// 4. All eruptions elevation > 2000m
// IEnumerable<Eruption> allEruptionsOver2000m = eruptions.Where(fe => fe.ElevationInMeters > 2000);
// PrintEach(allEruptionsOver2000m, "All Eruptions Over 2000m");
// 5. All Eruptions start with "z" and print how many found
// List<Eruption> allEruptionsStartWithZ = eruptions.Where(fe => fe.Volcano.StartsWith("Z")).ToList();
// PrintEach(allEruptionsStartWithZ, "How Many Eruptions that start with Z");
// Console.WriteLine(allEruptionsStartWithZ.Count);
// 6. Eruption with Highest Elevation
// Eruption? eruptionHighestElevation = eruptions.MaxBy(fe => fe.ElevationInMeters);
// Console.WriteLine(eruptionHighestElevation);
// 7. Print only the name of the Volcano with Highest Elevation
// Console.WriteLine(eruptionHighestElevation.Volcano);
// 8. All volcano names alphabetized
// IEnumerable<Eruption> allVolcanosABC = eruptions.OrderBy(fe => fe.Volcano);
// int r = 1; 
// foreach(var a in allVolcanosABC)
// {
//     Console.WriteLine($"{a.Volcano}");
//     r++;
// }
// 9. All Eruptions before Year 1000 Alphabetized by Volcano name
// IEnumerable<Eruption> allEruptionsBeforeYear1000 = eruptions.Where(fe => fe.Year < 1000).OrderBy(fe => fe.Volcano);
// PrintEach(allEruptionsBeforeYear1000, "All Eruptions Before Year 1000, Aphabetized");
// 10. bonus
IEnumerable<string> allEruptionsBeforeYear1000 = eruptions.Where(fe => fe.Year < 1000).OrderBy(fe => fe.Volcano).Select(fe => fe.Volcano);
foreach(var a in allEruptionsBeforeYear1000)
{
    Console.WriteLine($"{a}");
}


// PrintEach(allEruptionsBeforeYear1000, "All Eruptions Before Year 1000, Aphabetized");








// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
