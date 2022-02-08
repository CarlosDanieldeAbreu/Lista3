using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("FATORIAL");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("digite um número:");
            string Numero = Console.ReadLine();
            int A = Convert.ToInt32(Numero);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();

            int Fatorial = A;
            for (int i = A - 1; i >= 1 ; i--)
            { 
                Fatorial = Fatorial * i;
                Console.WriteLine(A + "! = " + i);
            }
            Console.WriteLine(" = " + Fatorial);
        }
    }
}
