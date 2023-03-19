
using Flyweight.Enums;
using Flyweight.FlyweightFactory;
using Flyweight.Flyweights;

ITree tree1 = TreeFactory.GetTree(TreeType.FIR);
tree1.DrawTree(10, 20, 5);

ITree tree2 = TreeFactory.GetTree(TreeType.FIR);
tree2.DrawTree(33, 22, 3);

ITree tree3 = TreeFactory.GetTree(TreeType.BIRCH);
tree3.DrawTree(15, 10, 6);

ITree tree4 = TreeFactory.GetTree(TreeType.BIRCH);
tree4.DrawTree(50, 220, 8);

ITree tree5 = TreeFactory.GetTree(TreeType.FIR);
tree5.DrawTree(120, 240, 5);

Console.ReadKey();