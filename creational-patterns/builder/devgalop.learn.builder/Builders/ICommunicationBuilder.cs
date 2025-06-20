using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.builder.Builders
{
    public interface ICommunicationBuilder
    {
        void AddTemplate(string body);
        void AddRecipients(List<string> recipients);
        void AddSignature(string signature);
        void AddSubject(string subject);
        void AddAttachments(List<string> attachments);
        void Send();
    }
}