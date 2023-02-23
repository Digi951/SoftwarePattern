using System;
using ProtectionPattern.Subject;

namespace ProtectionPattern.Proxy;

public class DownloadProductProxy : IDownloadableSubject
{
    private const Int32 NUM_DOWNLOADS_ALLOWED = 3;
    private Int32 numberDownloads = 0;
    private DownloadProduct downloadProduct;

    public DownloadProductProxy(String productName)
    {
        downloadProduct = new DownloadProduct(productName);
    }

    public void Dowwnload(Customer customer)
    {
        if (numberDownloads < NUM_DOWNLOADS_ALLOWED)
        {
            downloadProduct.Dowwnload(customer);
            numberDownloads++;
        }
        else
        {
            Console.WriteLine($"Das Produckt {downloadProduct.ProductName} hat das Downloadlimt erreicht!");
        }
    }
}

