using System;
using System.Threading;

namespace Decoratorr
{
    public abstract class Phone
    {
        protected string Number;
        protected string Model;
        protected int Layers = 1;

        public Phone(string number, string model)
        {
            this.Number = number;
            this.Model = model;
        }

        public Phone()
        {
        }

        public virtual void Call(string number)
        {
            Console.WriteLine(this.Number + " is calling to: " + number);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public virtual void TextMessage(string number, string text)
        {
            Console.WriteLine(this.Number + " is sending text message to: " + number);
            Console.WriteLine("Text: " + text);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public virtual int GetAmountOfLayers()
        {
            return Layers;
        }
    }
}