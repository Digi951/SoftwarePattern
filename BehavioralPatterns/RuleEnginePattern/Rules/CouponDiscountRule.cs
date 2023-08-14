using System;
using RuleEnginePattern.Enums;
using RuleEnginePattern.Models;

namespace RuleEnginePattern.Rules;

public class CouponDiscountRule : IDiscountRule
{
    public DiscountRule Type => DiscountRule.CouponDiscountRule;

    public decimal Apply(Customer customer, decimal currentDiscount)
    {
        if(customer.Years < 5)
        {
            return customer.Coupon.Discount + currentDiscount > 0.2m
                ? 0.2m
                : customer.Coupon.Discount + currentDiscount;
        }
        
        return customer.Coupon.Discount + currentDiscount > 0.25m
            ? 0.25m
            : customer.Coupon.Discount + currentDiscount;        
    }
}

