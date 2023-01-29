using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator;

public class MacBookTouchbarDecorator : MacBookBaseDecorator
{    
    public MacBookTouchbarDecorator(IMacBook macBook) : base(macBook)
    {
    }

    public override string GetDescription()
    {
        return _macBook.GetDescription() + " Zusätzlich wurde eine Touchbar verbaut!";
    }

    public override double GetPrice()
    {
        return _macBook.GetPrice() + 400.00;
    }
}

