using System;
using CompositePattern.Component;

namespace CompositePattern.Composite;

public class DirectoryComposite : FileSystemComponent
{
    private List<FileSystemComponent> _includedFiles = new();

    public DirectoryComposite(String name)
    {
        Name = name;
    }

    public override void Print(String spacing)
    {
        Console.WriteLine($"{spacing}Verzeichnis: {Name}" );

        foreach (var component in _includedFiles)
        {
            component.Print($"{spacing}     ");
        }
    }

    public void Add(FileSystemComponent component)
    {
        _includedFiles.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _includedFiles.Remove(component);
    }

    public FileSystemComponent GetFileSystemComponent(Int32 index)
    {
        return _includedFiles[index];
    }
}

