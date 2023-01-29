using System;

namespace StrategyPattern.Strategy;

public interface IInvestmentStrategy
{
    void Invest(Double investMoney);
}

