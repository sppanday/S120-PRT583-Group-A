using System;
namespace CommandPattern.After
{
    public interface Command
    {
        public void changeChannel();
        public void undoChannelChange();
    }
}
