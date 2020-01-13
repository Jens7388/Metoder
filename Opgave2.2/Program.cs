using System;

namespace Opgave2._2
{
    class Program
    {
        private static void PrintMenuHeader(string text)
        {
            Console.WriteLine($"*** {text} ***");
        }
        private static void PrintMenuItem(string text1, string text2, string text3)
        {
            Console.WriteLine($"1) {text1}");
            Console.WriteLine($"2) {text2}");
            Console.WriteLine($"3) {text3}");
        }
        static void Main(string[] args)
        {
            PrintMenuHeader("Great Leaders");
            PrintMenuItem("Donald Trump", "Vladimir Putin", "King Jong Un");
            Console.ReadLine();
        }
    }
}
