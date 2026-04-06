namespace AbstractFactorySample.Rules
{
    public interface IFileValidator
    {
        bool Exists(string filePath);
        bool IsCorrectEncoding(string filePath, string encoding);
    }
}