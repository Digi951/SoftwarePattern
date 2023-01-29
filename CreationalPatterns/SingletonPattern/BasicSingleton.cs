using System;

namespace SingletonPattern;

public class BasicSingleton
{
    private static readonly BasicSingleton _instance = new BasicSingleton();

    private BasicSingleton()
    {
        Console.WriteLine("Der Basic-Singleton wurde erstellt");
    }

    public static BasicSingleton GetInstance()
    {
        return _instance;
    }
}

