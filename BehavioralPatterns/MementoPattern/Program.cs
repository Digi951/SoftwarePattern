using MementoPattern;
using MementoPattern.Caretaker;
using MementoPattern.Originator;

Caretaker caretaker = new();

FitnessPlan plan = new ("Krafttraining");

Console.WriteLine(plan);
caretaker.SaveState(plan);

plan.ChangeTypeOfTraining("Joggen");
Console.WriteLine(plan);
caretaker.SaveState(plan);

plan.ChangeTypeOfTraining("Gemischtes Training");
Console.WriteLine(plan);
caretaker.SaveState(plan);

caretaker.RestoreState(plan, 0);
Console.WriteLine(plan);
Console.ReadKey();