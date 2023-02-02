using System;

namespace CompositePattern.Component;

public abstract class FileSystemComponent
{
    public String Name { get; set; }

    public abstract void Print(String spacing);
}

