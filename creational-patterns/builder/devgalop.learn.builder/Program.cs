using devgalop.learn.builder.Domain;
using devgalop.learn.builder.Builders;

Console.WriteLine("Builder Pattern Example");
Console.WriteLine("First example avoiding director class");
Console.WriteLine("==========================================");

ConcreteMailBuilder mailBuilder = new();
mailBuilder.AddSubject("This is a test of Builder Pattern avoiding director class");
mailBuilder.AddTemplate("This is the template body");
mailBuilder.AddSignature("Greetings, devgalop");
mailBuilder.AddAttachments(["/storage/my_attachment.zip"]);
mailBuilder.AddRecipients(["test_mail_1@yopmail.com", "test_mail_2@yopmail.com"]);
mailBuilder.Send();

Console.WriteLine("==========================================");
Console.WriteLine("Second example using director class");
Console.WriteLine("==========================================");
ConcreteMailBuilder mailBuilderWithDirector = new();
CommunicationDirector director = new();
director.BuildMailCommunication(mailBuilderWithDirector);
mailBuilderWithDirector.Send();
