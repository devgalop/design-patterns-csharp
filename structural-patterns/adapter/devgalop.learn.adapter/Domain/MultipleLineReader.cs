using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.adapter.Domain
{
    public class MultipleLineReader
    {
        public List<string> ReadLines(string path, int startLine, int endLine)
        {
            Console.WriteLine($"Reading lines from {startLine} to {endLine} in file at {path}");
            List<string> lines = new List<string>();
            return Enumerable.Range(startLine, endLine - startLine + 1)
                .Select(lineNumber => $"Line {lineNumber} from {path}")
                .ToList();
        }
    }
}