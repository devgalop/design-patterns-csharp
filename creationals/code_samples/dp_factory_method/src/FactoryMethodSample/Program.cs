using FactoryMethodSample.Rules;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.AddRules();

using IHost host = builder.Build();

//Create the factory and use it to create rules
RuleFactory factory = new();

//Create a numeric rule and a text rule using the factory
IRule numeric = factory.CreateRule(ERuleType.NUMERIC);
IRule text = factory.CreateRule(ERuleType.TEXT);

//Apply the rules
numeric.Apply();
text.Apply();