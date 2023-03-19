using System;
using Flyweight.Enums;

namespace Flyweight.Flyweights;

public interface ITree
{
    Color GetColor();

    TreeType GetTreeType();
    public void DrawTree(Int32 x, Int32 y, Int32 height);
}

