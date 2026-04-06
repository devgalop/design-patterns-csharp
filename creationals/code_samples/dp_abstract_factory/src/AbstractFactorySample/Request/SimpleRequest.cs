namespace AbstractFactorySample.Request
{
    public sealed record SimpleRequest(
        string Name,
        string FilePath,
        string Encoding
    );
}