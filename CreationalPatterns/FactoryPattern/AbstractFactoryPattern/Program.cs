using AbstractFactoryPattern;
using AbstractFactoryPattern.Factory;

QuadrocopterFactory flyFactory = new FlyFactory();

ControllerBoard controller = new (flyFactory);

Console.ReadKey();