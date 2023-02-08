using System;

namespace IteratorPattern.Iterator;

public class ChannelIteratorShuffleConcrete : IChannelIterator
{
    private List<Channel> _channels;
    private Int32 _currentPosition = 0;

    public ChannelIteratorShuffleConcrete(List<Channel> channels)
    {
        _channels = channels;
        Shuffle();
    }

    private void Shuffle()
    {
        var random = new Random();

        // Fisher-Yates Shuffle algorithm
        Int32 n = _channels.Count();

        while (n > 1)
        {
            n--;
            Int32 k = random.Next(n + 1);
            Channel value = _channels[k];
            _channels[k] = _channels[n];
            _channels[n] = value;
        }

    }

    public bool HasNext()
    {
        return _currentPosition < _channels.Count();
    }

    public Channel Next()
    {
        return _channels[_currentPosition++];
    }
}

