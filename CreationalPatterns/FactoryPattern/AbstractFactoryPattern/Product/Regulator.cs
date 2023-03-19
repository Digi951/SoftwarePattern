namespace AbstractFactoryPattern.Product;

public abstract class Regulator
{
    public Double CurrentVoltage { get; set; }
    public Double Current { get; set; }

    public abstract void IncreaseVoltage();
}
