using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.composite.Domain
{
    public class File : IFile
    {
        public virtual string Read(string path)
        {
            Console.WriteLine($"Reading generic file from {path}");
            return $"Content of file at {path}";
        }
    }
}