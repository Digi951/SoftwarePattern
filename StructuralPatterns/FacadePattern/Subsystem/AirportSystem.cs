using System;

namespace FacadePattern.Subsystem;

public class AirportSystem
{
    public void CheckLuggage()
    {
        Console.WriteLine("Das Gepäck wurde am Flughafen aufgenommen.");
    }

    public void TransportLuggageToAirplane()
    {
        Console.WriteLine("Das Gepäck wurde zum Flugzeug tansportiert.");
    }
}

