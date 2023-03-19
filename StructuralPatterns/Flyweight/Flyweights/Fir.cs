using System;
using Flyweight.Enums;

namespace Flyweight.Flyweights;

public class Fir : ITree
{
    private Color _color;
    private TreeType _treeType;

    public Fir()
    {
        _color = Color.BROWN;
        _treeType = TreeType.FIR;
    }

    public void DrawTree(int x, int y, int height)
    {
        Console.WriteLine($"Tanne wird auf der Koordinate x:{x}, y:{y} mit einer Höhe von {height} gezeichnet");
    }

    public Color GetColor() => _color;

    public TreeType GetTreeType() => _treeType;    
}

