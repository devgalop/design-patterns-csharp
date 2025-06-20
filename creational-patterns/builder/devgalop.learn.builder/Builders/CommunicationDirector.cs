using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.builder.Builders
{
    public class CommunicationDirector
    {
        public void BuildMailCommunication(ICommunicationBuilder builder)
        {
            builder.AddSubject("This is a test of Builder Pattern from Director Class");
            builder.AddTemplate("This is the template body from Director class");
            builder.AddSignature("Greetings, director");
            builder.AddAttachments(["/storage/my_attachment.zip"]);
            builder.AddRecipients(["test_mail_1@yopmail.com", "test_mail_2@yopmail.com"]);
        }
    }
}