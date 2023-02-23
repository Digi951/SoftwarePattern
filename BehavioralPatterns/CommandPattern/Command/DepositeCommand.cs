using System;
using CommandPattern.Receiver;

namespace CommandPattern.Command;

public class DepositeCommand : IBankTransactionCommand
{
    private Double _amount;
    private BankAccountReceiver _bankAccount;

    public DepositeCommand(BankAccountReceiver bankAccount, Double amount)
    {
        _amount = amount;
        _bankAccount = bankAccount;
    }

    public void Execute()
    {
        _bankAccount.Deposit(_amount);
    }

    public void Undo()
    {
        _bankAccount.Balance -= _amount;
        Console.WriteLine($"Die Einzahlung wurde rückgägig gemacht. Neuer Kontostand: {_bankAccount.Balance}");
    }
}

