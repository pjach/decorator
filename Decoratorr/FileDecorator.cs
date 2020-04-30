using System;
using System.Threading;

namespace Decoratorr
{
    public class FileDecorator : PhoneDecorator
    {
        private string _file;

        public FileDecorator(Phone phone, string role, string fileName, string fileType) : base(phone, role)
        {
            _file = fileName + "." + fileType;
        }

        public override void Call(string number)
        {
            base.Call(number);
            Console.WriteLine("Sending file: " + _file);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public override void TextMessage(string number, string text)
        {
            base.TextMessage(number, text);
            Console.WriteLine("Sending file: " + _file);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
        }

        public void OpenFile(string fileName, string fileType)
        {
            Console.WriteLine("Opening file: " + fileName + "." + fileType);
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Convert.ToString(random.Next(1000, 9999), 2).PadLeft(15, '0'));
            }
        }

        public override int GetAmountOfLayers()
        {
            return base.GetAmountOfLayers() + 1;
        }
    }
}