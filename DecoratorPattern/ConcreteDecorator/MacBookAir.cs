using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteDecorator;

public class MacBookAir : IMacBook
{
    public MacBookAir()
    {
    }

    public string GetDescription()
    {
        return "MachBook Air \nStandard Ausstattung";
    }

    public double GetPrice()
    {
        return 1199.00;
    }
}

