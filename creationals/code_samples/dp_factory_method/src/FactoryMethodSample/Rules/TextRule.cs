using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FactoryMethodSample.Rules
{
    public sealed class TextRule : IRule
    {
        public bool Apply()
        {
            Console.WriteLine("Applying text rule...");
            // Here would be the logic to apply the text rule
            return true; // Assuming the rule is applied successfully
        }
    }

    public static class TextRuleExtensions
    {
        public static HostApplicationBuilder AddTextRule(this HostApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IRule, TextRule>();
            return builder;
        }
    }
}