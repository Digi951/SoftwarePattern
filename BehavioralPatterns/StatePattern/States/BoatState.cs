using System;
using StatePattern.Context;

namespace StatePattern.States;

public class BoatState : State
{
    private AmphibiousVehicle _amphibiousVehicle;

    public BoatState(AmphibiousVehicle amphibiousVehicle)
    {
        _amphibiousVehicle = amphibiousVehicle;
    }

    public override void Accelerate()
    {
        Console.WriteLine("Beschleunige mit Hilfe der Schiffsschraube!");
    }

    public override void SlowDown()
    {
        Console.WriteLine("Bremse, indem die Schiffschraube in die andere Richtung dreht!");
    }
}

