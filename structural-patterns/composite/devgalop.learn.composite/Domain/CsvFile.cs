using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.composite.Domain
{
    public class CsvFile : File
    {
        override
        public string Read(string path)
        {
            Console.WriteLine($"Reading CSV file from {path}");
            return $"Content of CSV file at {path}";
        }
    }
}