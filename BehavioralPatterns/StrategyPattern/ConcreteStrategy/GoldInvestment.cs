using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy;

public class GoldInvestment : IInvestmentStrategy
{   
    public void Invest(double investMoney)
    {
        Console.WriteLine($"Du hast {investMoney} €uro in Gold investiert.");
    }
}

