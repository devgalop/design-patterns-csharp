using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devgalop.learn.composite.Domain
{
    public class Folder : IFile
    {
        private readonly List<IFile> _files;

        public Folder()
        {
            _files = [];
        }

        public void Add(IFile file)
        {
            _files.Add(file);
        }

        public void Remove(IFile file)
        {
            _files.Remove(file);
        }

        public string Read(string path)
        {
            StringBuilder sb = new();
            foreach (IFile file in _files)
            {
                string content = file.Read(path);
                Console.WriteLine(content);
                sb.AppendLine(content);
            }
            return sb.ToString();
        }
    }
}