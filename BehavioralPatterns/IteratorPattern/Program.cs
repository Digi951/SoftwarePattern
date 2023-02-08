
using IteratorPattern;
using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;

IChannelCollection radio = new CarRadio();
radio.AddChannel(new Channel("Radio Hamburg", 130.6));
radio.AddChannel(new Channel("DLF", 101.6));
radio.AddChannel(new Channel("Radio Bob", 106.6));

IChannelIterator iterator = radio.CreateIterator();

while(iterator.HasNext())
{
    Channel channel = iterator.Next();
    Console.WriteLine(channel);
}

Console.WriteLine(new String('#',20));

IChannelCollection radioShuffle = new BathroomRadio();
radioShuffle.AddChannel(new Channel("Radio Hamburg", 130.6));
radioShuffle.AddChannel(new Channel("DLF", 101.6));
radioShuffle.AddChannel(new Channel("Radio Bob", 106.6));

IChannelIterator iteratorShuffle = radioShuffle.CreateIterator();

while (iteratorShuffle.HasNext())
{
    Channel channel = iteratorShuffle.Next();
    Console.WriteLine(channel);
}

Console.ReadKey();
