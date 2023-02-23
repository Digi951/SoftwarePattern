using CommandPattern.Command;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

BankAccountReceiver bankAccount1 = new();
Console.WriteLine($"Konto wurde eröffnet: {bankAccount1}");

CashMachine cashMachine = new();

IBankTransactionCommand depositeCommand1 = new DepositeCommand(bankAccount1, 2000.0);
IBankTransactionCommand withdrawCommand = new WithdrawCommand(bankAccount1, 5000.0);
IBankTransactionCommand depositeCommand2 = new DepositeCommand(bankAccount1, 1000.0);

cashMachine.ExecuteBankTransaction(depositeCommand1);
// cashMachine.UndoBankTransaction(depositeCommand1);
cashMachine.ExecuteBankTransaction(withdrawCommand);
cashMachine.UndoBankTransaction(withdrawCommand);
cashMachine.ExecuteBankTransaction(depositeCommand2);

Console.ReadKey();

