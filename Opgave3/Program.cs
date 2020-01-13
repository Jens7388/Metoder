using System;

namespace Opgave3
{
    class Program
    {
        // Menu overskrift:
        private static void PrintMenuHeader(string text)
        {
            Console.WriteLine($"*** {text} ***");
        }
        // 3 Menu objekter
        private static void Print3MenuItems(string text1, string text2, string text3)
        {
            Console.WriteLine($"1) {text1}");
            Console.WriteLine($"2) {text2}");
            Console.WriteLine($"3) {text3}");
        }
        // 2 Menu objekter
        private static void Print2MenuItems(string text1, string text2)
        {
            Console.WriteLine($"1) {text1}");
            Console.WriteLine($"2) {text2}");
        }
        // Hovedmenu
        private static void MainMenu()
        {
            PrintMenuHeader("Hovedmenu");
            Print3MenuItems("Gå til udregninger", "Gå til tal", "Afslut programmet");
        }
        // Udregningsmenu
        private static void CalculationMenu()
        {
            Console.Clear();
            PrintMenuHeader("Udregninger");
            Print2MenuItems("Kvadrat og rod", "Tilbage til hovedmenuen");
        }
        // Talmenu
        private static void NumberMenu()
        {
            Console.Clear();
            PrintMenuHeader("Tal");
            Print3MenuItems("Er tallet positivt?", "Er tallet lige?", "Tilbage til hovedmenu");
        }
        // Udregn kvadratrod
        private static void SquareRoot(int number)
        {           
            if(number > 0)
            {
                Console.WriteLine($"Kvadratroden af {number} er: {Math.Sqrt(number)}");
            }
            else
            {
                Console.WriteLine("Ugyldigt tal! Prøv igen.");
                Console.Write("Skriv et positivt tal, og se dets kvadratrod: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numberInput);
                SquareRoot(numberInput);
            }
            Console.ReadLine();
        }
        // Se om tallet er positivt eller negativt
        private static bool IsPositive(int number)
        {
            if(number >= 0)
            {
                Console.WriteLine("Tallet er positivt");
                return true;
            }
            else
            {
                Console.WriteLine("Tallet er negativt");
                return false;
            }
        }
        // Se om tallet er lige eller ulige
        private static bool IsEven(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Tallet er lige");
                return true;
            }
            else
            {
                Console.WriteLine("Tallet er ulige");
                return false;
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {

                Console.Clear();
                MainMenu();
                string input = Console.ReadLine();
                if(input == "1")
                {
                    CalculationMenu();
                    input = Console.ReadLine();
                    if(input == "1")
                    {
                        Console.Write("Skriv et positivt tal, og se dets kvadratrod: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int numberInput);
                        SquareRoot(numberInput);
                    }
                    else if(input == "2")
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input! prøv igen");
                        Console.ReadLine();
                    }
                }
                else if(input == "2")
                {
                    NumberMenu();
                    input = Console.ReadLine();
                    if(input == "1")
                    {
                        Console.Write("Indtast et vilkårligt tal: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int numberInput);
                        IsPositive(numberInput);
                        Console.ReadLine();
                    }
                    else if(input == "2")
                    {
                        Console.Write("Skriv et tal: ");
                        input = Console.ReadLine();
                        int.TryParse(input, out int numberInput);
                        IsEven(numberInput);
                        Console.ReadLine();
                    }
                    else if(input == "3")
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input! prøv igen");
                        Console.ReadLine();
                    }
                }
                else if(input == "3")
                {
                    Environment.Exit(0);
                }
                //test
            }
        }
    }
}
