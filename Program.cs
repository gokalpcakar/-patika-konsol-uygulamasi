using System;

namespace patika_konsol_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Adınızı giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            string surName = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surName);
        }
    }
}
