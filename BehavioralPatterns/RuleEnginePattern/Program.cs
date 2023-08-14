using RuleEnginePattern;
using RuleEnginePattern.Models;
using RuleEnginePattern.Enums;
using RuleEnginePattern.Engine;

var customers = new List<Customer>
{
    new()
    {
        Name = "Customer1",
        Plan = Plan.Internet,
        Years = 4,
        Coupon = new Coupon(0.05m)
    },
    new()
    {
        Name = "Customer2",
        Plan = Plan.Phone,
        Years = 3,
        Coupon = new Coupon(0.15m)
    },
    new()
    {
        Name = "Customer3",
        Plan = Plan.PhoneAndInternet,
        Years = 6,
        Coupon = new Coupon(0.15m)
    }
};

var engine = new RuleEngine();

foreach(var customer in customers)
{
    var discount = engine.Run(customer);
    Console.WriteLine($"{customer.Name} has a discount of {discount}");
}

Console.ReadKey();