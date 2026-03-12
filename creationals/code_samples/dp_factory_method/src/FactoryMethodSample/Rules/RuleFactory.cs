namespace FactoryMethodSample.Rules
{
    public enum ERuleType
    {
        NUMERIC,
        TEXT
    }
    
    public sealed class RuleFactory
    {
        public IRule CreateRule(ERuleType type)
        {
            return type switch
            {
                ERuleType.NUMERIC => new NumericRule(),
                ERuleType.TEXT => new TextRule(),
                _ => throw new InvalidRuleException(type.ToString()),
            };
        }
    }
}