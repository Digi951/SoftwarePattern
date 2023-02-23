using ProtectionPattern.Proxy;
using ProtectionPattern.Subject;

var customer = new Customer("Jim Panse");

var downloadProduct = new DownloadProductProxy("C# in a nutshell");

downloadProduct.Dowwnload(customer);
downloadProduct.Dowwnload(customer);
downloadProduct.Dowwnload(customer);
downloadProduct.Dowwnload(customer);

Console.ReadKey();