using System;

namespace VirtualProxyPattern.Subject;

public class Customers : ICustomers
{
    public List<Customer> GetCustomers()
    {
        var customers = new List<Customer>();

        customers.Add(new Customer("Rainer Zufall", "Hauptstraße 21, Neustadt", bonusCard: true));
        customers.Add(new Customer("Claire Grube", "Am Wasserfall 32, Altstadt", bonusCard: false));
        customers.Add(new Customer("Frank Furt", "Am Kai 43, Oderfurth", bonusCard: false));
        customers.Add(new Customer("Jim Panse", "Vogelallee 54, Nixforf", bonusCard: true));

        Console.WriteLine("Kundenliste wurde geladen");

        return customers;
    }
}

