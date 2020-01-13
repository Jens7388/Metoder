using System;

namespace Opgave1._6
{
    class Program
    {
        private static void Max(double number1, double number2)
        {
            if(number1 > number2)
            {
                Console.WriteLine($"{number1} er større end {number2}");
            }
            else if(number2 > number1)
            {
                Console.WriteLine($"{number2} er større end {number1}");
            }
            else
            {
                Console.WriteLine("De to tal er ens");
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast 2 kommatal, og se hvilket der er størst: ");
                Console.Write("Indtast første tal: ");
                string input = Console.ReadLine();
                double.TryParse(input, out double numberInput1);
                Console.Write("Indtast andet tal: ");
                input = Console.ReadLine();
                double.TryParse(input, out double numberInput2);
                Max(numberInput1, numberInput2);
                Console.ReadLine();
                Console.Clear();
            }         
        }
    }
}
