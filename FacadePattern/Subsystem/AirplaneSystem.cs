using System;
namespace FacadePattern.Subsystem;

public class AirplaneSystem
{
    public void PutLuggageIn()
    {
        Console.WriteLine("Das Gepäck wurde ins Flugzeug eingeladen.");
    }

    public void PutLuggageOut()
    {
        Console.WriteLine("Das Gepäck wurd das dem Flugzeug ausgeladen.");
    }
}

