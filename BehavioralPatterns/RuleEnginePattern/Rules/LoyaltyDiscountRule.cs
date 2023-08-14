using System;
using RuleEnginePattern.Enums;
using RuleEnginePattern.Models;

namespace RuleEnginePattern.Rules;

public class LoyaltyDiscountRule : IDiscountRule
{
    public DiscountRule Type => DiscountRule.LoyaltyDiscountRule;

    public decimal Apply(Customer customer, decimal currentDiscount)
    {
        return customer.Years > 3
            ? currentDiscount + 0.05m
            : currentDiscount;
    }
}

