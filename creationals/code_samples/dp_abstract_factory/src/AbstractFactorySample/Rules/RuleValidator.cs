using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;

namespace AbstractFactorySample.Rules
{
    public interface IRuleValidator
    {
        IDocumentValidator CreateDocumentValidator();
        IFileValidator CreateFileValidator();
    }
}