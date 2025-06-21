using devgalop.learn.prototype.Domain;

Console.WriteLine("Prototype Pattern Example");
Console.WriteLine("Creating an object from class Employee");
Console.WriteLine("==========================================");
ConcreteEmployee employee = new("Admin");
string roleEmployee = employee.GetRole();
Console.WriteLine($"Role from original employee is: {roleEmployee}");

Console.WriteLine("==========================================");
Console.WriteLine("Creating a clone from class Employee");
Console.WriteLine("==========================================");
ConcreteEmployee cloneEmployee = (ConcreteEmployee)employee.Clone();
roleEmployee = cloneEmployee.GetRole();
Console.WriteLine($"Role from clone employee is: {roleEmployee}");