
using System;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

var sportnewsletter = new SportnewsletterSubject(new Newsletter("Tipps für dein Workout!", "Hier erfährst du, wie du dein Training optimieren kannst..."));

var person1 = new PersonObserver("Frank Furt");
var person2 = new PersonObserver("Jim Panse");
var person3 = new PersonObserver("Rainer Zufall");

sportnewsletter.Subscribe(person1);
sportnewsletter.Subscribe(person2);

sportnewsletter.SetNewsletter(new Newsletter("Olymische Spiele","Dieses Land überrascht alle!"));

sportnewsletter.Unsubscribe(person1);
sportnewsletter.Subscribe(person3);

sportnewsletter.SetNewsletter(new Newsletter("Fußballweltmeisterschaft", "Schon wieder in der Vorrunde raus..."));

Console.ReadKey();