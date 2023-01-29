using System;
namespace FacadePattern.Subsystem;

public class LocalTransportCompanySystem
{
    public void PutLuggageIntoTruck()
    {
        Console.WriteLine("Das Gepäck wurde in einen Truck geladen.");
    }

    public void TransportLuggageToHotel()
    {
        Console.WriteLine("Das Gepäck wurde zum Hotel gebracht.");
    }
}

