﻿using System;
namespace SingletonPattern
{
    public class LazySingleton
    {
        private static LazySingleton _instance;

        private LazySingleton()
        {            
            Console.WriteLine("Der Lazy-Singleton wurde erstellt");
        }

        // Creates the instance if needed
        public static LazySingleton GetInstance()
        {
            if (_instance is null) { _instance = new LazySingleton(); }

            return _instance;
        }
    }
}

