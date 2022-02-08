using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("TABUADA");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("digite um número:");
            string Numero = Console.ReadLine();
            int N = Convert.ToInt32(Numero);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================");
            Console.ResetColor();

            int resultado = 0;
            for (int i = 0; i < 11; i++)
            {
                resultado = N * i;
                Console.WriteLine(i + "X" + N + " = " + resultado);
            }
        }
    }
}
