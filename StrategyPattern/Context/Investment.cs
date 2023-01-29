using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.Context;

public class Investment
{
    private Double _investmentMoney;
    private Boolean _talkedToBankEmployee = false;
    private IInvestmentStrategy _investmentStrategy;  

    public Investment(double investmentMoney)
    {
        _investmentMoney = investmentMoney;
    }

    public void SetInvestmentStrategy(IInvestmentStrategy strategy)
    {
        _investmentStrategy = strategy;
        Console.WriteLine("Die Strategie wurde geändert.");
    }

    public void TalkToBankEmployee()
    {
        _talkedToBankEmployee = true;
        Console.WriteLine("Das Beratungsgespräch wurde durchgeführt.");
    }

    public void MakeInvestment()
    {
        if (_investmentStrategy is not null && _talkedToBankEmployee)
        {
            _investmentStrategy.Invest(_investmentMoney);
        }
        else
        {
            Console.WriteLine("Die Kriterien für ein Investment wurden noch nicht erfüllt");
        }
    }
}

