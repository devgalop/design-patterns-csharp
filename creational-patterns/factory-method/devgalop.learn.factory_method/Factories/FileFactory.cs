using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.factory_method.Domain;

namespace devgalop.learn.factory_method.Factories
{
    public abstract class FileFactory
    {
        public abstract IFile CreateFileObj();
    }
}