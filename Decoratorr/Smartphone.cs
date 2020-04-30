using System;
using System.Threading;

namespace Decoratorr
{
    public class SmartPhone : Phone
    {
        private string _os;

        public SmartPhone(string number, string model, string os) : base(number, model)
        {
            this._os = os;
        }

        public void ShowOs()
        {
            Console.WriteLine("Operating system: " + _os);
        }

        public override void Call(string number)
        {
            Console.WriteLine(this.Number + " is calling to: " + number + " over 4G");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }
    }
}