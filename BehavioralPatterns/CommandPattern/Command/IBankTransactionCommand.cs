using System;

namespace CommandPattern.Command;

public interface IBankTransactionCommand
{
    void Execute();
    void Undo();
}

