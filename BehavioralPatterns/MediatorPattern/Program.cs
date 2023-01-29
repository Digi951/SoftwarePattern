using MediatorPattern.Colleague;
using MediatorPattern.Mediator;

var chatroom = new ChatMediatorConcrete();

var user1 = new UserConcrete("Frank Furt", chatroom);
var user2 = new UserConcrete("Jim Panse", chatroom);
var user3 = new UserConcrete("Rainer Zufall", chatroom);
var user4 = new UserConcrete("Claire Grube", chatroom);

chatroom.AddUder(user1);
chatroom.AddUder(user2);
chatroom.AddUder(user3);
chatroom.AddUder(user4);

user3.SendBroadcast("Hi zusammen!");

user1.SendPrivateMessage("Moin Rainer!", user3);
Console.ReadKey();
