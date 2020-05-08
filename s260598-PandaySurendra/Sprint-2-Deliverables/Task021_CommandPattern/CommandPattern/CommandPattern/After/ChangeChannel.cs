using System;
namespace CommandPattern.After
{
    /*
     * @author : Surendra Panday
     */
    public class ChangeChannel: Command 
    {
        Channels[] tv;
        string tvName;
      
        public ChangeChannel(Channels[] tv, string tvName)
        {
            this.tv = tv;
            this.tvName = tvName;
        }

        public ChangeChannel()
        {
        }

        public void changeChannel()
        {
            for (int i = 0; i < tv.Length; i++)
            {
                tv[i].changeChannel();
            }
        }

        public void undoChannelChange()
        {
            for (int i = 0; i < tv.Length; i++)
            {
                tv[i].undoChannelChange();
            }
        }
    }
}
