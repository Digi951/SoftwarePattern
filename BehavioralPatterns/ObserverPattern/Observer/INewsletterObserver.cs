using System;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer;

public interface INewsletterObserver
{
    public void Update(Newsletter newsletter);
}

