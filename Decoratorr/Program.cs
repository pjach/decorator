using System;

namespace Decoratorr
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileDecorator file = new FileDecorator(new LocationDecorator(new VideoDecorator(
             new MobilePhone("869453109", "Galaxy S8"),
             "Video", "0101010100010001010100001010"), "Location", 24.23, 12.54), "File", "project", "docx");
            FileDecorator smartphone = new FileDecorator(new LocationDecorator(new VideoDecorator(
            new SmartPhone("869453122", "Galaxy S8", "Android"),
            "Video", "0101010100010001010100001010"), "Location", 24.23, 12.54), "File", "project", "docx");
            // file.TextMessage("869287198", "Labas");
            //smartphone.Call("867546189");
            Console.WriteLine(Environment.NewLine);
            // Phone phon = PhoneDecorator.GetRole(file, "Video");
            // ((VideoDecorator)phon).TextMessage("861199", "Sveiki!");
            Phone ph = PhoneDecorator.RemoveRole(file, "Location");
            ((FileDecorator)ph).Call("865839182");
            Console.ReadKey();
        }
    }
}