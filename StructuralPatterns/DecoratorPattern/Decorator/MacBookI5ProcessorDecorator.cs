using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator;

public class MacBookI5ProcessorDecorator : MacBookBaseDecorator
{
    public MacBookI5ProcessorDecorator(IMacBook macBook) : base(macBook)
    {
    }

    public override string GetDescription()
    {
        return _macBook.GetDescription() + " Zusätzlich wurde ein i5 verbaut!";
    }

    public override double GetPrice()
    {
        return _macBook.GetPrice() + 500.00;
    }
}

