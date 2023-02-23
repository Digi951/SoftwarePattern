using VirtualProxyPattern.Proxy;
using VirtualProxyPattern.Subject;

ICustomers customers = new CustomersProxy();
var company = new Company("Fahrrad Meyer", "Hauptstraße 1, Neustadt", customers);

Console.WriteLine(company.Name);
List<Customer> finalCustomers = customers.GetCustomers();

finalCustomers.ForEach(c => Console.WriteLine(c));

Console.ReadKey();
