namespace CommandPattern
{
     public class TvChannel {
        
        Channels[] channels;
        public TvChannel(Channels[] channels) {
            this.channels = channels;
        }

        changeChannel()
        {
            for(int = 0; i < channels.Length; i++)
            {
                return channels[i].changeChannel();
            }
        }
     }

}