using AbstractFactorySample.Request;

namespace AbstractFactorySample.Rules
{
    public interface IDocumentValidator
    {
        bool Validate(SimpleRequest request);
    }
}