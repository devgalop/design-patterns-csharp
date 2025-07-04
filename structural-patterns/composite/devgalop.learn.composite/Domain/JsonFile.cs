using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.composite.Domain
{
    public class JsonFile : File
    {
        override
        public string Read(string path)
        {
            Console.WriteLine($"Reading JSON file from {path}");
            return $"Content of JSON file at {path}";
        }
    }
}