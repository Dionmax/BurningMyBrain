using System;

namespace Aula202_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2019, 08, 02, 8, 10, 45);
            string st1 = "Good morning dear students!";

            Console.WriteLine(dateTime.ElipsedTime());

            Console.WriteLine(st1.Cut(10));
        }
    }
}
