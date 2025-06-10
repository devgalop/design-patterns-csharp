using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.factory_method.Domain;

namespace devgalop.learn.factory_method.Factories
{
    public class JsonFileFactory : FileFactory
    {
        public override IFile CreateFileObj()
        {
            Console.WriteLine("Creating a JSON file object.");
            return new JsonFile();
        }
    }
}