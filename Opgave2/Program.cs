using System;

namespace Opgave2
{
    class Program
    {
        private static void PrintMenuHeader(string text)
        {
            Console.WriteLine($"*** {text} ***");
        }
        private static void PrintMenuItem(string text)
        {
            Console.WriteLine($"1) {text}");
        }
        static void Main(string[] args)
        {
            PrintMenuHeader("Animals");
            PrintMenuItem("Cow");
            Console.ReadLine();
        }
    }
}
