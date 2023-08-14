using System;
using RuleEnginePattern.Enums;

namespace RuleEnginePattern.Models;

public class Customer
{
    public required String Name { get; set; }
    public Plan Plan { get; set; }
    public Int32 Years { get; set; }
    public required Coupon Coupon { get; set; }
}

