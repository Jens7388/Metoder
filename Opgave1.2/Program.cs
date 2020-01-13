using System;

namespace Opgave1._2
{
    class Program
    {
        private static void PrintResult(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");       
        }
        static void Main(string[] args)
        {
            Console.Write("Indtast første tal: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int numberInput1);
            Console.Write("Indtast andet tal: ");
            input = Console.ReadLine();
            int.TryParse(input, out int numberInput2);
            PrintResult(numberInput1, numberInput2);
        }
    }
}
