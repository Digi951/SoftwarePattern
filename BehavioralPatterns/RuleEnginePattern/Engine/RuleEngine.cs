using System;
using System.Reflection;
using RuleEnginePattern.Models;
using RuleEnginePattern.Rules;

namespace RuleEnginePattern.Engine;

public class RuleEngine
{
    private readonly IEnumerable<IDiscountRule> _rules;

    public RuleEngine()
    {
        _rules = GetRules();
    }

    public Decimal Run(Customer customer)
    {
        var currentDiscount = 0m;

        foreach(var rule in _rules)
        {
            currentDiscount = rule.Apply(customer, currentDiscount);
        }

        return currentDiscount;
    }

    private static IEnumerable<IDiscountRule>? GetRules()
    {
        var type = typeof(IDiscountRule);

        var rules = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(x => type.IsAssignableFrom(x) && !x.IsInterface)
            .Select(x => (IDiscountRule)Activator.CreateInstance(x)!)
            .OrderBy(x => x.Type)
            .ToList();

        return rules;
    }
}

