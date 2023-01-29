using System;
using FacadePattern.Subsystem;

namespace FacadePattern.Facade;

public class LuggageManagementFacade
{
    private AirportSystem _airport;
    private AirplaneSystem _airplane;
    private LocalTransportCompanySystem _company;
    private HotelSystem _hotel;

    public LuggageManagementFacade()
    {
        _airport = new AirportSystem();
        _airplane = new AirplaneSystem();
        _company = new LocalTransportCompanySystem();
        _hotel = new HotelSystem();
    }

    public void SendLuggage()
    {
        _airport.CheckLuggage();
        _airport.TransportLuggageToAirplane();

        _airplane.PutLuggageIn();
        _airplane.PutLuggageOut();

        _company.PutLuggageIntoTruck();
        _company.TransportLuggageToHotel();

        _hotel.TransportLuggageToRoom();
    }
}

