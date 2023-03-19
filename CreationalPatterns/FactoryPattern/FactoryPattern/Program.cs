using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Product;

Logistics creator = new LogisticsFactory();

Transport? transport = creator.ProvideTransport(TransportType.Sea);

Console.ReadKey();
