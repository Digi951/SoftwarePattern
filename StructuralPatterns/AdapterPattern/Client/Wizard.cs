using System;
namespace AdapterPattern.Client
{
    public class Wizard
    {
        public void AttackOpponent()
        {
            Console.WriteLine("Der Zauberer greift an!");
        }

        public void Rest()
        {
            Console.WriteLine("Der Zauberer ruht sich aus.");
        }

        public void Communicate()
        {
            Console.WriteLine("Der Zauberer sagt 'Flieht ihr Narren!'");
        }
    }
}

