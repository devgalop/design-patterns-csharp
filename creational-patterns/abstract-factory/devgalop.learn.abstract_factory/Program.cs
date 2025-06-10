using devgalop.learn.abstract_factory.Factories;
using devgalop.learn.abstract_factory.Domain.Helmets;
using devgalop.learn.abstract_factory.Domain.Jackets;

Console.WriteLine("Abstract Factory Pattern Example");
Console.WriteLine("Creating a new riding gear using the abstract factory...");
Console.WriteLine("==========================================");

Console.WriteLine("Creating a Richa riding gear instance:");
IRidingGearFactory ridingGearFactory = new RichaRidingGearFactory();
IHelmet helmet = ridingGearFactory.CreateHelmetObj();
IJacket jacket = ridingGearFactory.CreateJacketObj();
ShowHelmetDetails(helmet);
ShowJacketDetails(jacket);
Console.WriteLine("==========================================");


Console.WriteLine("Creating a FP riding gear instance:");
ridingGearFactory = new FPRidingGearFactory();
helmet = ridingGearFactory.CreateHelmetObj();
jacket = ridingGearFactory.CreateJacketObj();
ShowHelmetDetails(helmet);
ShowJacketDetails(jacket);
Console.WriteLine("==========================================");

void ShowHelmetDetails(IHelmet helmet)
{
    Console.WriteLine($"Helment selected: {helmet.GetCertification()} - {helmet.GetDescription()} [Is available: {helmet.IsAvailable()}]");
}

void ShowJacketDetails(IJacket jacket)
{
    Console.WriteLine($"Jacket selected: {jacket.GetSize()} - {jacket.GetDescription()} [Is available: {jacket.IsAvailable()}]");
}