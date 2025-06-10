using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.factory_method.Domain
{
    public interface IFile
    {
        bool IsValidExtension(string fileName);
    }
}