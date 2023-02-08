using System;

namespace IteratorPattern.Iterator;

public interface IChannelIterator
{
    Boolean HasNext();
    Channel Next();
}

