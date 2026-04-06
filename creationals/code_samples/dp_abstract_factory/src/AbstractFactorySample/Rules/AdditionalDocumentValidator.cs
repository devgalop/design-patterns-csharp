using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactorySample.Request;

namespace AbstractFactorySample.Rules
{
    public sealed class AdditionalDocumentValidator : IDocumentValidator
    {
        public bool Validate(SimpleRequest request)
        {
            Console.WriteLine("Validando documento adicional...");
            return !string.IsNullOrEmpty(request.Name)
                && !string.IsNullOrEmpty(request.FilePath)
                && !string.IsNullOrEmpty(request.Encoding)
                && request.Name.StartsWith("Additional", StringComparison.OrdinalIgnoreCase);
        }
    }
}