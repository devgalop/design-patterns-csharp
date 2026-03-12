using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace FactoryMethodSample.Rules
{
    public static class RuleExtensions
    {
        public static HostApplicationBuilder AddRules(this HostApplicationBuilder builder)
        {
            builder.AddNumericRule()
                    .AddTextRule();
                    
            return builder;
        }
    }
}