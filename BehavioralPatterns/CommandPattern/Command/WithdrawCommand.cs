using System;
using CommandPattern.Receiver;

namespace CommandPattern.Command;

public class WithdrawCommand : IBankTransactionCommand
{
    private Double _amount;
    private BankAccountReceiver _bankAccount;
    private Boolean _transactionSucceeded;

    public WithdrawCommand(BankAccountReceiver bankAccount, Double amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }

    public void Execute()
    {
        _transactionSucceeded = _bankAccount.Withdraw(_amount);
    }

    public void Undo()
    {
        if (_transactionSucceeded)
        {
            _bankAccount.Balance += _amount;
            Console.WriteLine($"Die Auszahlung wurde rückgägig gemacht. Neuer Kontostand: {_bankAccount.Balance}");
        }
        else
        {
            Console.WriteLine("Konnte Undo-Operation nicht durchführen");
        }
    }
}

