using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory;

public class FlyFactory : QuadrocopterFactory
{    
    public override Engine CreateEngine() => new FlyEngine();

    public override Regulator CreateRegulator() => new FlyRegulator();
}
