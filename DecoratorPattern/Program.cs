using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;

var macBookAir = new MacBookAir();

Console.WriteLine(macBookAir.GetDescription());
Console.WriteLine(macBookAir.GetPrice() + "€");

var macBookPro = new MacBookPro();
var macBookTouchbar= new MacBookTouchbarDecorator(macBookPro);
var macBookTouchbarI5Processor = new MacBookI5ProcessorDecorator(macBookTouchbar);


Console.WriteLine(macBookTouchbarI5Processor.GetDescription());
Console.WriteLine(macBookTouchbarI5Processor.GetPrice() + "€");

Console.ReadKey();
