using System;

namespace EventAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending message...." + args.Video.Title);
        }
    }
}
