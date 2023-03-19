namespace AbstractFactoryPattern.Product;

public abstract class Engine
{
    public Double EngineSpeed { get; set; }

    public abstract void RevCounter();
}
