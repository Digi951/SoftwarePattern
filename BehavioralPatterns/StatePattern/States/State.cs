using System;

namespace StatePattern.States;

public abstract class State
{
    public abstract void Accelerate();
    public abstract void SlowDown();    
}

