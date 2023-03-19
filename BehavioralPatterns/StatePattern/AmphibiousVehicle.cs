using System;
using StatePattern.States;

namespace StatePattern;

public class AmphibiousVehicle
{
    private CarState _car;
    private BoatState _boat;

    private State _currentState;

    public AmphibiousVehicle()
    {
        _car = new CarState(this);
        _boat = new BoatState(this);

        _currentState = _car;
    }

    public void PrepareForWater()
    {
        Console.WriteLine("Das Fahrzeug wurde für das Wasser vorbereitet!");
        _currentState = _boat;
    }

    public void PrepareForLand()
    {
        Console.WriteLine("Das Fahrzeug wurde für das Land vorbereitet!");
        _currentState = _car;
    }

    public void Accelerate()
    {
        _currentState.Accelerate();
    }

    public void SlowDown()
    {
        _currentState.SlowDown();
    }
}

