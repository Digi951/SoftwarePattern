using System;
using CompositePattern.Component;

namespace CompositePattern.Leaf;

public class FileLeaf : FileSystemComponent
{
    public String Owner { get; set; }

    public FileLeaf(String name, String owner)
    {
        Name = name;
        Owner = owner;
    }

    public override void Print(String spacing)
    {
        Console.WriteLine($"{spacing}Dateiname {Name} Besitzer: {Owner}");
    }
}

