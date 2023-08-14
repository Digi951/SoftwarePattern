using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handler;

public class VicePresident : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 25000.0)
        {
            Console.WriteLine($"{this.GetType().Name} approved request # {purchase.Number}");
        }
        else if (_successor is not null)
        {
            _successor.ProcessRequest(purchase);
        }
    }
}

