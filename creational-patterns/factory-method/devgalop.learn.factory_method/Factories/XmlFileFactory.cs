using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.factory_method.Domain;

namespace devgalop.learn.factory_method.Factories
{
    public class XmlFileFactory : FileFactory
    {
        public override IFile CreateFileObj()
        {
            Console.WriteLine("Creating a XML file object.");
            return new XmlFile();
        }
    }
}