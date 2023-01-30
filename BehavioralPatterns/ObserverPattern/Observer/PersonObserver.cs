using System;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    public class PersonObserver : INewsletterObserver
    {
        private String _name;
        private Newsletter _currentNewsletter;

        public PersonObserver(String name)
        {
            _name = name;
        }

        public void Update(Newsletter newsletter)
        {
            _currentNewsletter = newsletter;
            Console.WriteLine($"{_name} hat den Newsletter zum Thema {_currentNewsletter.Topic} erhalten!");
        }
    }
}

