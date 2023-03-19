namespace AbstractFactoryPattern.Product;

public class FlyEngine : Engine
{
    public FlyEngine()
    {
        Console.WriteLine("Die FlyEngine wurde erstellt!");
    }

    public override void RevCounter()
    {
        Console.WriteLine("Die Drehzahl beträgt 300U/min!");
    }
}

