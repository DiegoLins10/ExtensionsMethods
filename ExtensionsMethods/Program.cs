using ExtensionsMethods.Extensions;
using System;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            DateTime dt2 = new DateTime(2021, 11, 28, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine(dt2.ElapsedTime());
            TimeSpan duration = DateTime.Now.TimeOfDay;
            Console.WriteLine(duration);
            Console.WriteLine("-------------------------------------");
            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
