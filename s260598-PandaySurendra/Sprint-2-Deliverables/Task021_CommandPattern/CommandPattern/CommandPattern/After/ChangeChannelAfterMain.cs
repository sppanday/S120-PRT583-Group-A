using System;
namespace CommandPattern.After
{
    public class ChangeChannelAfterMain
    {
        static void Main(string[] args)
        {
            TV tv = new TV("Living Room");
            TelevisionOffCommand television = new TelevisionOffCommand();
            ChangeChannel remote = new ChangeChannel(tv);
        }
    }
}
