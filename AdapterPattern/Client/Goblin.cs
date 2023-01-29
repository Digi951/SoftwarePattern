using System;
using AdapterPattern.Target;

namespace AdapterPattern.Client;

public class Goblin : IEnemyTarget
{   
    public void Attack()
    {
        Console.WriteLine("Der Goblin greift an!");
    }

    public void SayHello()
    {
        Console.WriteLine("Der Goblin begrüßt dich.");
    }

    public void Sleep()
    {
        Console.WriteLine("Der Goblin legt sich schlafen zZZ.");
    }
}

