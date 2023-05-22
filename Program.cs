using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "";

            Console.WriteLine("Hallo Welt!");
            Console.WriteLine("-------------------\n");

            Console.WriteLine("Gib deinen Namen ein ...");
            name = Console.ReadLine();
            Console.WriteLine("\nHallo Welt, mein Name ist " + name + ".\n");

            Console.WriteLine("Programm mit 'Enter' beenden ...");
            Console.ReadLine();
        }
    }
}
