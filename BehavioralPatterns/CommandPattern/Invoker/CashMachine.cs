using System;
using CommandPattern.Command;

namespace CommandPattern.Invoker;

public class CashMachine
{
    public void ExecuteBankTransaction(IBankTransactionCommand command)
    {
        command.Execute();
        // Protokollieren
    }

    public void UndoBankTransaction(IBankTransactionCommand command)
    {
        command.Undo();
    }
}
