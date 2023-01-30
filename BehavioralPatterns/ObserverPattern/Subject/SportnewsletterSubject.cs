using System;

namespace ObserverPattern.Subject;

public class SportnewsletterSubject : NewsletterSubject
{
    private Newsletter _currentNewsletter;

    public Newsletter GetNewsletter
    {
        get => _currentNewsletter;
    }

    public SportnewsletterSubject(Newsletter newsletter)
    {
        _currentNewsletter = newsletter;
    }
           
    public void SetNewsletter(Newsletter newNewsletter)
    {
        _currentNewsletter = newNewsletter;
        Console.WriteLine("Es ist ein neuer Newsletter erschienen!");
        SendNewsletter(_currentNewsletter);
    }
}
