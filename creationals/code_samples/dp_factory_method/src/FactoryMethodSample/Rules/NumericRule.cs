using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FactoryMethodSample.Rules
{
    public sealed class NumericRule : IRule
    {
        public bool Apply()
        {
            Console.WriteLine("Applying numeric rule...");
            // Here would be the logic to apply the numeric rule
            return true; // Assuming the rule is applied successfully
        }
    }

    public static class NumericRuleExtensions
    {
        public static HostApplicationBuilder AddNumericRule(this HostApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IRule, NumericRule>();
            return builder;
        }
    }
}