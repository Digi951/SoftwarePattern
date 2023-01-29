using SingletonPattern;

var basicSingleton1 = BasicSingleton.GetInstance();
var basicSingleton2 = BasicSingleton.GetInstance();

var lazySingleton1 = LazySingleton.GetInstance();
var lazySingleton2 = LazySingleton.GetInstance();

Console.ReadKey();
