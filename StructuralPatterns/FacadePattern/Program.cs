
using FacadePattern.Facade;
using FacadePattern.Subsystem;

// Client
var bookingSystem = new LuggageManagementFacade();
bookingSystem.SendLuggage();

Console.ReadKey();