using System;
using AdapterPattern.Client;
using AdapterPattern.Target;

namespace AdapterPattern.Adapter;

public class WizardAdapter : IEnemyTarget
{
    private Wizard _wizard;

    public WizardAdapter(Wizard wizard)
    {
        _wizard = wizard;
    }

    public void Attack()
    {
        _wizard.AttackOpponent();
    }

    public void SayHello()
    {
        _wizard.Communicate();
    }

    public void Sleep()
    {
        _wizard.Rest();
    }
}

