using System;

namespace StatePattern.States;

public class CarState : State
{
    private AmphibiousVehicle _amphibiousVehicle;

    public CarState(AmphibiousVehicle amphibiousVehicle)
    {
        _amphibiousVehicle = amphibiousVehicle;
    }

    public override void Accelerate()
    {
        Console.WriteLine("Beschleunige mit dem Motor und den 4 Rädern!");
    }

    public override void SlowDown()
    {
        Console.WriteLine("Verwende die Bremse um langsamer zu werden!");
    }
}

