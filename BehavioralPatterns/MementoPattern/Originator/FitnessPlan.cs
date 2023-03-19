using System;
using MementoPattern.Mementos;

namespace MementoPattern.Originator;

public class FitnessPlan
{
    private String _typeOfTraining;

    public FitnessPlan(String typeOfTraining)
    {
        _typeOfTraining = typeOfTraining;
    }

    public void ChangeTypeOfTraining(String typeOfTraining)
    {
        _typeOfTraining = typeOfTraining;
    }

    public override string ToString()
    {
        return $"Trainingsart: {_typeOfTraining}"; 
    }

    public Memento Save()
    {
        Console.WriteLine("Zustand wurde gespeichert");
        return new Memento(_typeOfTraining);
    }

    public void Restore(Memento saveState)
    {
        Console.WriteLine("Zustand wurde wiederhergestellt");
        _typeOfTraining = saveState.GetState();
    }
}

