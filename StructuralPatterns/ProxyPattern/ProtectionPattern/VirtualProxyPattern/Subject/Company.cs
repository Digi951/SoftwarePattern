using System;

namespace VirtualProxyPattern.Subject;

public class Company
{
    public String Name { get; set; }
    public String Address { get; set; }
    public ICustomers Customers { get; set; }

    public Company(String name, String address, ICustomers customers)
    {
        Name = name;
        Address = address;
        Customers = customers;
    }
}