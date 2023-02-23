using System;
using VirtualProxyPattern.Subject;

namespace VirtualProxyPattern.Proxy;

public class CustomersProxy : ICustomers
{
    private ICustomers _customers;

    public CustomersProxy()
    {
    }

    public List<Customer> GetCustomers()
    {
        if (_customers is null)
        {
            Console.WriteLine("Die Kundenliste wird aus der Datenbank geladen...");
            _customers = new Customers();
        }

        return _customers.GetCustomers();
    }
}

