namespace AbstractFactoryPattern.Product;

public class FlyRegulator : Regulator
{
    public FlyRegulator()
    {
        Console.WriteLine("Der FlyRegulator wurde erstellt!");
    }

    public override void IncreaseVoltage()
    {
        Console.WriteLine("Die Spannung wurde um 10V erhöht!");
    }
}

