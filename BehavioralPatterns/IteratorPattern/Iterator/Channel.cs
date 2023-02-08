using System;

namespace IteratorPattern.Iterator;

public class Channel
{
    public String Name { get; set; }
    public Double Frequency { get; set; }

    public Channel(String name, Double frequency)
    {
        Name = name;
        Frequency = frequency;
    }

    public override String ToString()
    {
        return $"Du hörst gerade {Name} ({Frequency})";
    }
}

