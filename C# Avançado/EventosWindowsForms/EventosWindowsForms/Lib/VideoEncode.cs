using System;
using System.Threading;

namespace EventosWindowsForms.Lib
{
    public class VideoEncode
    {
        public delegate void VideoEncodedHandler(Video video);

        public event VideoEncodedHandler Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine(@"Convertendo o vídeo...");
            Thread.Sleep(2000);
            Console.WriteLine(@"Vídeo convertido.");

            Encoded(video);
        }
    }
}