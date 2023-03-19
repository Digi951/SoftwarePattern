namespace FactoryMethodPattern.Product;

public class StreetTransport : Transport
{   
    public override void TransportProduct()
    {
        Console.WriteLine("Die Produkte werden über den Straßenweg transportiert");
    }
}

