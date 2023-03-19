namespace FactoryMethodPattern.Product;

public class FlightTransport : Transport
{
    public override void TransportProduct()
    {
        Console.WriteLine("Die Produkte werden über den Luftweg transportiert");
    }
}

