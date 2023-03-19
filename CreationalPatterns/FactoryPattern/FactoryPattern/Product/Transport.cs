namespace FactoryMethodPattern.Product;

public abstract class Transport
{
    public String Customer { get; set; } = String.Empty;
    public String Destination { get; set; } = String.Empty;

    public void CollectProductFromCustomer()
    {
        Console.WriteLine("Die Produkte werden abgeholt!");
    }

    public abstract void TransportProduct();
}

