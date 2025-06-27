
using devgalop.learn.bridge.Domain;

Console.WriteLine("Bridge Pattern Example");
Console.WriteLine("Assigning admin permissions...");
Console.WriteLine("==========================================");

IPermission dbPermission = new DatabasePermission();
IPermission landingPermission = new LandingPermission();

Role role = new AdminRole([dbPermission, landingPermission]);
role.AssignPermissions();

Console.WriteLine("==========================================");
Console.WriteLine("Assigning support permissions...");
Console.WriteLine("==========================================");
role = new SupportRole([landingPermission]);
role.AssignPermissions();

