using System;
namespace AdapterPattern.Target;

public interface IEnemyTarget
{
    void Attack();
    void Sleep();
    void SayHello();
}

