using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactorySample.Request;

namespace AbstractFactorySample.Rules
{
    public sealed class SpoolDocumentValidator : IDocumentValidator
    {
        public bool Validate(SimpleRequest request)
        {
            Console.WriteLine("Validando documento de spool...");
            return !string.IsNullOrEmpty(request.Name)
                && request.Name.StartsWith("Spool", StringComparison.OrdinalIgnoreCase)
                && !string.IsNullOrEmpty(request.FilePath)
                && !string.IsNullOrEmpty(request.Encoding);
        }
    }
}