using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.builder.Domain
{
    public class CommunicationBase
    {
        public string Subject { get; set; } = string.Empty;
        public List<string>? Recipients { get; set; }
        public List<string>? Attachments { get; set; }
        public string Signature { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}