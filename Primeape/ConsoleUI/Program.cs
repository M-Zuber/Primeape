using Models;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Pikachu();
            Console.WriteLine(pikachu);
            var ashesPikachu = new Pikachu("Ashes");
            Console.WriteLine(ashesPikachu);
        }
    }
}
