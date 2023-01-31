using System;
using TemplatePattern.Template;

namespace TemplatePattern.ConcreteImplementation;

public class ManagerWorkday : WorkdayPlannerTemplate
{    
    public override void GoToWork()
    {
        Console.WriteLine("Manager fährt ins Büro");
    }

    protected override void Work()
    {
        Console.WriteLine("Manager managed sein Abteil");
    }
}

