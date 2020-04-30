using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoratorr
{
    public interface IPhone
    {
        void Call(String number);
        void TextMessage(String number, String text);
        int GetAmountOfLayers();
    }
}
