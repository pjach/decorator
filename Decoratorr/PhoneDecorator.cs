using System;

namespace Decoratorr
{
    public class PhoneDecorator : Phone
    {
        protected Phone Phone;
        protected string Role;

        public PhoneDecorator(Phone phone, string role)
        {
            this.Phone = phone;
            this.Role = role;
        }

        public override void Call(string number)
        {
            Phone.Call(number);
        }

        public override void TextMessage(string number, string text)
        {
            Phone.TextMessage(number, text);
        }

        public string GetRoleName()
        {
            return Role;
        }

        public static PhoneDecorator GetRole(Phone phone, string role)
        {
            if (((PhoneDecorator)phone).GetRoleName().Equals(role))
            {
                return (PhoneDecorator)phone;
            }
            else if (((PhoneDecorator)phone).Phone is PhoneDecorator)
            {
                return PhoneDecorator.GetRole(((PhoneDecorator)phone).Phone, role);
            }
            else return null;
        }

        public static Phone RemoveRole(Phone phone, string role)
        {
            Phone temp = phone;
            if (((PhoneDecorator)phone).GetRoleName().Equals(role))
            {
                return ((PhoneDecorator)temp).Phone;
            }
            else if (((PhoneDecorator)phone).Phone is PhoneDecorator &&
                ((PhoneDecorator)((PhoneDecorator)phone).Phone).GetRoleName().Equals(role))
            {
                ((PhoneDecorator)temp).Phone = ((PhoneDecorator)((PhoneDecorator)phone).Phone).Phone;
                return temp;
            }
            else PhoneDecorator.RemoveRole(((PhoneDecorator)phone).Phone, role);
            return temp;
        }

        public override int GetAmountOfLayers()
        {
            return Phone.GetAmountOfLayers();
        }
    }
}