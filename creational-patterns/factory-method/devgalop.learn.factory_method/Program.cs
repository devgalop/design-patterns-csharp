using devgalop.learn.factory_method.Domain;
using devgalop.learn.factory_method.Factories;


Console.WriteLine("Factory Method Pattern Example");
Console.WriteLine("Creating a new file using the factory method...");
Console.WriteLine("==========================================");

List<string> fileExtensions = [".csv", ".json", ".xml"];

Console.WriteLine("Creating a CSV file instance:");
CsvFileFactory csvFactory = new();
IFile file = csvFactory.CreateFileObj();
Console.WriteLine("Results of CSV file validation:");
ValidateFileExtensions(file, fileExtensions);
Console.WriteLine("==========================================");

Console.WriteLine("Creating a XML file instance:");
XmlFileFactory xmlFactory = new();
file = xmlFactory.CreateFileObj();
Console.WriteLine("Results of XML file validation:");
ValidateFileExtensions(file, fileExtensions);
Console.WriteLine("==========================================");

Console.WriteLine("Creating a JSON file instance:");
JsonFileFactory jsonFactory = new();
file = jsonFactory.CreateFileObj();
Console.WriteLine("Results of JSON file validation:");
ValidateFileExtensions(file, fileExtensions);
Console.WriteLine("==========================================");

void ValidateFileExtensions(IFile file, List<string> extensions)
{
    foreach (string extension in extensions)
    {
        bool isValid = file.IsValidExtension(extension);
        Console.WriteLine($"Validating '{extension}' extension: {isValid}");
    }
}