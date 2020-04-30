using System;
using System.Threading;

namespace Decoratorr
{
    public class VideoDecorator : PhoneDecorator
    {
        private string _video;

        public VideoDecorator(Phone phone, string role, string video) : base(phone, role)
        {
            this._video = video;
        }

        public override void Call(string number)
        {
            base.Call(number);
            Console.WriteLine("Adding video: " + _video);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public override void TextMessage(string number, string text)
        {
            base.TextMessage(number, text);
            Console.WriteLine("Adding image: " + _video);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public string TakeSnapshotDuringVideoCall()
        {
            Random random = new Random();
            return Convert.ToString(random.Next(100, 999), 2).PadLeft(10, '0');
        }

        public override int GetAmountOfLayers()
        {
            return base.GetAmountOfLayers() + 1;
        }
    }
}