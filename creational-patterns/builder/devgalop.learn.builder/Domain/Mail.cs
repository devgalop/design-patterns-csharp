using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.builder.Domain
{
    public class Mail : CommunicationBase
    {
        public static string MailId => Guid.NewGuid().ToString();
        public static DateTime Date => DateTime.UtcNow;
        
    }
}