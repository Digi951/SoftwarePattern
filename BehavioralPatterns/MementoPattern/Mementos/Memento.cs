using System;

namespace MementoPattern.Mementos;

public class Memento
{
    private String _typeOfTraining;

    public Memento(String typeOfTraining)
    {
        _typeOfTraining = typeOfTraining;
    }

    public String GetState()
    {
        return _typeOfTraining;
    }
}

