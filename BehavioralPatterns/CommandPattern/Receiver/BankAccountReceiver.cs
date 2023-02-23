using System;

namespace CommandPattern.Receiver;

public class BankAccountReceiver
{
    public Double Balance { get; set; }
    public Double OverdraftLimit { get; set; } = -1000;


    public void Deposit(Double amount)
    {
        Balance += amount;
        Console.WriteLine($"Es wurden {amount}€ auf das Konto eingezahlt!\nDer neue Kontostand beträgt {Balance}€.");
    }

    public Boolean Withdraw(Double amount)
    {
        if (Balance - amount > OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Es wurden {amount}€ auf das Konto abgehoben!\nDer neue Kontostand beträgt {Balance}€.");
            return true;
        }
        else
        {
            Console.WriteLine("Es ist leider nicht genügend Geld auf dem Konto vorhanden.");
            return false;
        }
        
    }

    public override string ToString()
    {
        return $"Kontostand: {Balance}, Dispo: {OverdraftLimit}";
    }

}

