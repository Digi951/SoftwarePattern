using System;
using RuleEnginePattern.Enums;
using RuleEnginePattern.Models;

namespace RuleEnginePattern.Rules;

public interface IDiscountRule
{
    public DiscountRule Type { get; }

    Decimal Apply(Customer customer, Decimal currentDiscount);
}

