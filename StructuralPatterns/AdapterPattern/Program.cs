using AdapterPattern.Adapter;
using AdapterPattern.Client;
using AdapterPattern.Target;

IEnemyTarget goblin = new Goblin();
goblin.Attack();
goblin.SayHello();
goblin.Sleep();

var wizard = new Wizard();
IEnemyTarget wizardAdapter = new WizardAdapter(wizard);
wizardAdapter.Attack();
wizardAdapter.SayHello();
wizardAdapter.Sleep();

Console.ReadKey();
