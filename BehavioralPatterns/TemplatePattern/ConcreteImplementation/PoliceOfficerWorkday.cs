using System;
using TemplatePattern.Template;

namespace TemplatePattern.ConcreteImplementation;

public class PoliceOfficerWorkday : WorkdayPlannerTemplate
{
    public override void GoToWork()
    {
        Console.WriteLine("Polizist fährt zur Wache");
    }

    protected override void Work()
    {
        Console.WriteLine("Polizist beschützt die Bürger");
    }
}

