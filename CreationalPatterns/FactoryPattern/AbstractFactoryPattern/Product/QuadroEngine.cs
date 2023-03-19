namespace AbstractFactoryPattern.Product;

public class QuadroEngine : Engine
{
    public QuadroEngine()
    {
        Console.WriteLine("Die QuadroEngine wurde erstellt!");
    }

    public override void RevCounter()
    {
        Console.WriteLine("Die Drehzahl beträgt 100U/min!");
    }
}
