using System;
using RuleEnginePattern.Enums;
using RuleEnginePattern.Models;

namespace RuleEnginePattern.Rules;

public class PlanDiscountRule : IDiscountRule
{
    public DiscountRule Type => DiscountRule.PlanDiscountRule;

    public decimal Apply(Customer customer, decimal currentDiscount)
    {
        return customer.Plan is Plan.Internet or Plan.Phone
            ? currentDiscount + 0.10m
            : currentDiscount + 0.15m;
    }
}

