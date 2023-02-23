using System;

namespace ProtectionPattern.Subject;

public class DownloadProduct : IDownloadableSubject
{
    public String ProductName { get; set; }

    public DownloadProduct(String productName)
    {
        ProductName = productName;
    }

    public void Dowwnload(Customer customer)
    {
        Console.WriteLine($"{customer.Name} hat das Produkt {ProductName} heruntergeladen.");
    }
}

