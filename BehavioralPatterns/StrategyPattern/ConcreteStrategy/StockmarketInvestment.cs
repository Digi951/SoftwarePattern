using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class StockmarketInvestment : IInvestmentStrategy
    {      
        public void Invest(double investMoney)
        {
            Console.WriteLine($"Du hast {investMoney} €uro in Aktien investiert.");
        }
    }
}

