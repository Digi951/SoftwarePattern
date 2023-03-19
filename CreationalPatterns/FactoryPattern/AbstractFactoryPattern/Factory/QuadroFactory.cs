using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory;

public class QuadroFactory : QuadrocopterFactory
{
    public override Engine CreateEngine() => new QuadroEngine();

    public override Regulator CreateRegulator() => new QuadroRegulator();
    
}