using System;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class BathroomRadio : IChannelCollection
    {
        private List<Channel> _channels;

        public BathroomRadio()
        {
            _channels = new List<Channel>();
        }

        public void AddChannel(Channel channel)
        {
            _channels.Add(channel);
        }

        public IChannelIterator CreateIterator()
        {
            return new ChannelIteratorShuffleConcrete(_channels);
        }

        public void RemoveChannel(Channel channel)
        {
            _channels.Remove(channel);
        }
    }
}

