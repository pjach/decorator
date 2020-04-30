using System;

namespace Decoratorr
{
    public class MobilePhone : Phone
    {
        public MobilePhone(string number, string model) : base(number, model)
        {
        }

        public void TurnOnRadio()
        {
            Console.WriteLine("Radio is on");
        }
    }
}