using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encoder(Video video)
        {
            Console.WriteLine("Encoding");
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video1" };
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();    //sibcriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encoder(video);
        }
    }
}