using System;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject;

public abstract class NewsletterSubject
{
    private List<INewsletterObserver> _observers = new();

    public void Subscribe(INewsletterObserver observer)
    {
        if(!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Unsubscribe(INewsletterObserver observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer); 
        }
    }

    // Notify
    public void SendNewsletter(Newsletter newNewsletter)
    {
        foreach (var observer in _observers)
        {
            observer.Update(newNewsletter);
        }
    }
}

