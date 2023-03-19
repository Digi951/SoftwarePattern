using System;
using Flyweight.Enums;

namespace Flyweight.Flyweights;

public class Birch : ITree
{
    private Color _color;
    private TreeType _treeType;

    public Birch()
    {
        _color = Color.WHITE;
        _treeType = TreeType.BIRCH;
    }

    public void DrawTree(int x, int y, int height)
    {
        Console.WriteLine($"Birke wird auf der Koordinate x:{x}, y:{y} mit einer Höhe von {height} gezeichnet");
    }

    public Color GetColor() => _color;

    public TreeType GetTreeType() => _treeType;
}

