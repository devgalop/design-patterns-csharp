using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using devgalop.learn.builder.Domain;

namespace devgalop.learn.builder.Builders
{
    public class ConcreteMailBuilder : ICommunicationBuilder
    {
        private readonly Mail _mail;

        public ConcreteMailBuilder()
        {
            _mail = new Mail();
        }

        public void AddAttachments(List<string> attachments)
        {
            Console.WriteLine("Add attachments to mail");
            _mail.Attachments = attachments;
        }

        public void AddRecipients(List<string> recipients)
        {
            Console.WriteLine("Add recipients to mail");
            _mail.Recipients = recipients;
        }

        public void AddSignature(string signature)
        {
            Console.WriteLine("Add signature to mail");
            _mail.Signature = signature;
        }

        public void AddSubject(string subject)
        {
            Console.WriteLine("Add subject to mail");
            _mail.Subject = subject;
        }

        public void AddTemplate(string body)
        {
            Console.WriteLine("Add template body to mail");
            _mail.Body = body;
        }

        public void Send()
        {
            string communication = JsonSerializer.Serialize(_mail);
            Console.WriteLine($"Message sent successfully {communication}");
        }

        public Mail GetResult()
        {
            return _mail;
        }
    }
}