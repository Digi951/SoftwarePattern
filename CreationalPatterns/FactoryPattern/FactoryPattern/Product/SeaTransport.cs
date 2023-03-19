namespace FactoryMethodPattern.Product;

public class SeaTransport : Transport
{    
    public override void TransportProduct()
    {
        Console.WriteLine("Die Produkte werden über den Seeweg transportiert");
    }
}

