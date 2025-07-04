using devgalop.learn.composite.Domain;

Console.WriteLine("Composite Pattern Example");
Console.WriteLine("Creating file system structure...");
Console.WriteLine("==========================================");

IFile jsonFile = new JsonFile();
IFile csvFile = new CsvFile();
IFile genericFile = new devgalop.learn.composite.Domain.File();
Folder rootFolder = new Folder();
rootFolder.Add(jsonFile);
rootFolder.Add(genericFile);
Folder subFolder = new Folder();
subFolder.Add(csvFile);
rootFolder.Add(subFolder);


string content = jsonFile.Read("path/to/jsonFile.json");
Console.WriteLine("==========================================");
Console.WriteLine($"Completed reading JSON file : {content}");
Console.WriteLine("==========================================");
content = csvFile.Read("path/to/csvFile.csv");
Console.WriteLine("==========================================");
Console.WriteLine($"Completed reading CSV file : {content}");
Console.WriteLine("==========================================");
content = genericFile.Read("path/to/genericFile.tk");
Console.WriteLine("==========================================");
Console.WriteLine($"Completed reading Generic file : {content}");
Console.WriteLine("==========================================");
content = subFolder.Read("path/to/subFolder");
Console.WriteLine("==========================================");
Console.WriteLine($"Completed reading Subfolder : {content}");
Console.WriteLine("==========================================");
content = rootFolder.Read("path/to/rootFolder");
Console.WriteLine("==========================================");
Console.WriteLine($"Completed reading root folder : {content}");
Console.WriteLine("==========================================");