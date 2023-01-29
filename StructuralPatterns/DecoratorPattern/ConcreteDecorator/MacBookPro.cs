using System;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteDecorator
{
    public class MacBookPro : IMacBook
    {
        public MacBookPro()
        {
        }

        public string GetDescription()
        {
            return "MacBook Pro \nStandard Ausstattung.";
        }

        public double GetPrice()
        {
            return 1599.00;
        }
    }
}

