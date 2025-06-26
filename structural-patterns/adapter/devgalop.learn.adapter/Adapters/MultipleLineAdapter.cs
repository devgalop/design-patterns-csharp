using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.adapter.Domain;

namespace devgalop.learn.adapter.Adapters
{
    public class MultipleLineAdapter : IFileReader
    {
        private readonly MultipleLineReader _multipleLineReader;
        private const int LINES_TO_READ = 10;

        public MultipleLineAdapter(MultipleLineReader multipleLineReader)
        {
            _multipleLineReader = multipleLineReader;
        }

        public string ReadLine(string path, int lineNumber)
        {
            Console.WriteLine($"Reading line {lineNumber} from multiple lines in file at {path}");
            List<string> lines = _multipleLineReader.ReadLines(path, lineNumber, lineNumber + LINES_TO_READ);
            string result = string.Join(Environment.NewLine, lines);
            return result;
        }
    }
}