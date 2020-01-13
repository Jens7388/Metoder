using System;

namespace Opgave1._5
{
    class Program
    {
        private static void CalculateAndPrint(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"Kvadratroden af {number} er: {Math.Sqrt(number)}");
            }
            else
            {
                Console.WriteLine("Ugyldigt tal! Prøv igen.");
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Skriv et positivt tal, og se dets kvadratrod: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numberInput);
                CalculateAndPrint(numberInput);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
