using System;
namespace IteratorPattern.Iterator;

public class ChannelIteratorNormalConcrete : IChannelIterator
{
    private List<Channel> _channels;
    private Int32 _currentPosition = 0;

    public ChannelIteratorNormalConcrete(List<Channel> channels)
    {
        _channels = channels;
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

