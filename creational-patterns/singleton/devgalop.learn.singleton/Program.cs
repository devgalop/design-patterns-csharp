using devgalop.learn.singleton.Domain;

Console.WriteLine("Singleton Pattern Example");
Console.WriteLine("Creating a database instance");
Console.WriteLine("==========================================");
Database dbInstance1 = Database.GetInstance();
Console.WriteLine($"Database instance identifier 1 :{dbInstance1.InstanceId}");
Database dbInstance2 = Database.GetInstance();
Console.WriteLine($"Database instance identifier 2 :{dbInstance2.InstanceId}");
bool areEquals = dbInstance1 == dbInstance2;
Console.WriteLine($"Comparinson result: {areEquals}");