using System;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class CarRadio : IChannelCollection
    {
        private List<Channel> _channels;

        public CarRadio()
        {
            _channels = new List<Channel>();
        }

        public void AddChannel(Channel channel)
        {
            _channels.Add(channel);
        }

        public IChannelIterator CreateIterator()
        {
            return new ChannelIteratorNormalConcrete(_channels);
        }

        public void RemoveChannel(Channel channel)
        {
            _channels.Remove(channel);
        }
    }
}

