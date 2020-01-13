using System;

namespace Opgave1._3
{
    class Program
    {
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
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et vilkårligt tal: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numberInput);
                IsPositive(numberInput);
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
