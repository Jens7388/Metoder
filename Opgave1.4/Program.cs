using System;

namespace Opgave1._4
{
    class Program
    {
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
                Console.Write("Skriv et tal: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numberInput);
                IsEven(numberInput);
                Console.ReadLine();
                Console.Clear();
            }       
        }
    }
}
