using System;
using MementoPattern.Mementos;
using MementoPattern.Originator;

namespace MementoPattern.Caretaker;

public class Caretaker
{
    private List<Memento> _mementos;

    public Caretaker()
    {
        _mementos = new List<Memento>();
    }

    public void SaveState(FitnessPlan fitnessPlan)
    {
        _mementos.Add(fitnessPlan.Save());
    }

    public void RestoreState(FitnessPlan fitnessPlan, Int32 index)
    {
        fitnessPlan.Restore(_mementos[index]);
    }
}

