using System;

namespace TemplatePattern.Template;

public abstract class WorkdayPlannerTemplate
{
    public void CreateWorkday()
    {
        WakeUp();
        TakeShower();
        Breakfast();
        GoToWork();
        Work();
        Sleep();
    }
        
    public abstract void GoToWork();

    protected abstract void Work();

    public void WakeUp()
    {
        Console.WriteLine("Aufwachen...");
    }

    public void TakeShower()
    {
        Console.WriteLine("Duschen...");
    }

    public void Breakfast()
    {
        Console.WriteLine("Frühstücken...");
    }


    public void Sleep()
    {
        Console.WriteLine("Schlafen...");
    }
}

