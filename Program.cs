// See https://aka.ms/new-console-template for more information
IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(@"stores");

foreach (var dir in listOfDirectories)
{
    Console.WriteLine(dir);
}
IEnumerable<string> files = Directory.EnumerateFiles("stores");

foreach (var file in files)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/sales.json