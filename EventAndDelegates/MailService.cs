using System;

namespace EventAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService : Sending Mail...." + e.Video.Title);
        }
    }

}
