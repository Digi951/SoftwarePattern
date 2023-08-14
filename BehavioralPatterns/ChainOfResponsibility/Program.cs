using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Models;

Approver larry = new Director();
Approver sam = new VicePresident();
Approver tammy = new President();

// Set up chain of Responsibility
larry.SetSuccessor(sam);
sam.SetSuccessor(tammy);

// Generate and process purchase requests
Purchase purchase = new()
{
    Number = 2034,
    Amount = 350.00,
    Purpose = "Supplies"
};

larry.ProcessRequest(purchase);

purchase = new()
{
    Number = 2035,
    Amount = 32590.10,
    Purpose = "Project X"
};

larry.ProcessRequest(purchase);

purchase = new()
{
    Number = 2036,
    Amount = 122100.00,
    Purpose = "Project Y"
};

larry.ProcessRequest(purchase);

Console.ReadKey();

