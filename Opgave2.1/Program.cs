using System;

namespace Opgave2._1
{
    class Program
    {
        private static void PrintMenuHeader(string text)
        {
            Console.WriteLine($"*** {text} ***");
        }
        private static void PrintMenuItem(string text1, string text2)
        {
            Console.WriteLine($"1) {text1}");
            Console.WriteLine($"2) {text2}");
        }
        static void Main(string[] args)
        {
            PrintMenuHeader("Countries");
            PrintMenuItem("Tuvalu", "Nauru");
            Console.ReadLine();
        }
    }
}
