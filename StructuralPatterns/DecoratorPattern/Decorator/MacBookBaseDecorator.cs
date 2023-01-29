using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator;

public abstract class MacBookBaseDecorator : IMacBook
{
    protected IMacBook _macBook;

    public MacBookBaseDecorator(IMacBook macBook)
    {
        _macBook = macBook;
    }

    public abstract String GetDescription();
    public abstract Double GetPrice();    
}

