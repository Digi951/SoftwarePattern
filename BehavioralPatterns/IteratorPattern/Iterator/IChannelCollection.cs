using System;

namespace IteratorPattern.Iterator;

public interface IChannelCollection
{
    void AddChannel(Channel channel);
    void RemoveChannel(Channel channel);
    IChannelIterator CreateIterator();
}

