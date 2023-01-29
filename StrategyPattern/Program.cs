
using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Context;

var investment = new Investment(300.00);
investment.SetInvestmentStrategy(new GoldInvestment());
investment.TalkToBankEmployee();
investment.MakeInvestment();
Console.ReadKey();
