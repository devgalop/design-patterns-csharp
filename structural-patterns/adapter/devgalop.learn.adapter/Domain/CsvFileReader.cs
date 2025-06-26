using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.adapter.Domain
{
    public class CsvFileReader : IFileReader
    {
        public string ReadLine(string path, int lineNumber)
        {
            Console.WriteLine($"Reading line {lineNumber} from CSV file at {path}");
            return $"CSV Line {lineNumber} from {path}";
        }
    }
}