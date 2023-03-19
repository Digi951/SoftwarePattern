using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Creator;

public class LogisticsFactory : Logistics
{
    protected override Transport? CreateTransport(TransportType transportType)
    {
        Transport? transport = transportType switch
        {
            TransportType.Air => new FlightTransport(),
            TransportType.Sea => new SeaTransport(),
            TransportType.Street => new StreetTransport(),
            _ => null
        };

        return transport;
    }
}
