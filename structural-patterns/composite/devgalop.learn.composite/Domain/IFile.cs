using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.composite.Domain
{
    public interface IFile
    {
        string Read(string path);
    }
}