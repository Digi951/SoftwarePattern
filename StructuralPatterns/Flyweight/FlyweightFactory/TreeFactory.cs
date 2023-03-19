using System;
using Flyweight.Enums;
using Flyweight.Flyweights;

namespace Flyweight.FlyweightFactory;

public class TreeFactory
{
    public static Dictionary<TreeType, ITree> _treeDictionary = new();

    public static ITree GetTree(TreeType treeType)
    {
        if (!_treeDictionary.ContainsKey(treeType))
        {
            ITree? tree = null;

            switch (treeType)
            {
                case TreeType.FIR:
                    tree = new Fir();
                    Console.WriteLine("Tanne wurde erstellt");
                    break;
                case TreeType.BIRCH:
                    tree = new Birch();
                    Console.WriteLine("Birke wurde erstellt");
                    break;                
            }

            if (tree is null)
            {
                throw new Exception("Ungültiger TreeType");
            }

        _treeDictionary[treeType] = tree;
        }

        return _treeDictionary[treeType];
    }

    public TreeFactory()
    {
    }
}

