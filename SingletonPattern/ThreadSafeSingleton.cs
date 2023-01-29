using System;

namespace SingletonPattern;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton _instance;
    private static object lockObject = new object();

    private ThreadSafeSingleton()
    {
        Console.WriteLine("Der ThreadSafe-Singleton wurde erstellt");
    }

    public static ThreadSafeSingleton GetInstance()
    {
        lock (lockObject)
        {
            if (_instance is null) { _instance = new ThreadSafeSingleton(); }
        }        

        return _instance;
    }
}
