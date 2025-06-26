using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.adapter.Domain
{
    public interface IFileReader
    {
        string ReadLine(string path, int lineNumber);
    }
}