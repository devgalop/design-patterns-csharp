namespace FactoryMethodSample.Rules
{
    public sealed class InvalidRuleException : Exception
    {
        public string RuleName { get; }
        public InvalidRuleException(string name)
            : base($"Invalid rule: {name}")
        {
            RuleName = name;
        }
    }
}