using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Creator;

public abstract class Logistics
{
    protected abstract Transport? CreateTransport(TransportType transportType);

    public Transport? ProvideTransport(TransportType transportType)
    {
        Transport? transport = CreateTransport(transportType);

        transport?.CollectProductFromCustomer();
        transport?.TransportProduct();

        return transport;
    }
}

