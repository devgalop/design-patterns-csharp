using devgalop.learn.adapter.Adapters;
using devgalop.learn.adapter.Domain;

Console.WriteLine("Adapter Pattern Example");
Console.WriteLine("Reading a line from a file without adapter...");
Console.WriteLine("==========================================");

IFileReader reader = new CsvFileReader();
string lineRead = reader.ReadLine("example.csv", 1);
Console.WriteLine($"Read line: {lineRead}");

Console.WriteLine("==========================================");
Console.WriteLine("Reading a line from a file using the adapter...");
Console.WriteLine("==========================================");

MultipleLineReader multipleLineReader = new MultipleLineReader();
reader = new MultipleLineAdapter(multipleLineReader);
lineRead = reader.ReadLine("example.txt", 1);
Console.WriteLine($"Read line: {lineRead}");