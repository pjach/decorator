using System;
using System.Threading;

namespace Decoratorr
{
    public class LocationDecorator : PhoneDecorator
    {
        private double _latitude;
        private double _longitude;

        public LocationDecorator(Phone phone, string role, double latitude, double longitude) : base(phone, role)
        {
            this._latitude = latitude;
            this._longitude = longitude;
        }

        public override void Call(string number)
        {
            base.Call(number);

            Console.WriteLine("Location: latitude: " + _latitude + " longitude: " + _longitude);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public override void TextMessage(string number, string text)
        {
            base.TextMessage(number, text);
            Console.WriteLine("Location: latitude: " + _latitude + " longitude: " + _longitude);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public double GetLatitude()
        {
            return _latitude;
        }

        public double GetLongitude()
        {
            return _longitude;
        }

        public override int GetAmountOfLayers()
        {
            return base.GetAmountOfLayers() + 1;
        }
    }
}