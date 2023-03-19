namespace AbstractFactoryPattern.Product;

public class QuadroRegulator : Regulator
{
    public QuadroRegulator()
    {
        Console.WriteLine("Der QuadroRegulator wurde erstellt!");
    }

    public override void IncreaseVoltage()
    {
        Console.WriteLine("Die Spannung wurde um 30V erhöht!");
    }
}

