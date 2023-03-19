using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern;

public class ControllerBoard
{
    public Regulator CurrentRegulator { get; set; }
    public Engine CurrentEngine { get; set; }
    public QuadrocopterFactory UsedFactory { get; set; }

    public ControllerBoard(QuadrocopterFactory usedFactory)
    {
        UsedFactory = usedFactory;

        CreateParts();
    }

    private void CreateParts()
    {
        CurrentRegulator = UsedFactory.CreateRegulator();
        CurrentEngine = UsedFactory.CreateEngine();
    }
}

