using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.factory_method.Domain
{
    public class XmlFile : IFile
    {
        public bool IsValidExtension(string fileName)
        {
            return fileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase);
        }
    }
}