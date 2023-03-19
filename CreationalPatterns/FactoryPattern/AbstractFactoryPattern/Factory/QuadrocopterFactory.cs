using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory;

public abstract class QuadrocopterFactory
{
    public abstract Engine CreateEngine();
    public abstract Regulator CreateRegulator();
}
