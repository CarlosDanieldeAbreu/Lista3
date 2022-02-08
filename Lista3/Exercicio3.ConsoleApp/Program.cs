using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 1)
                {
                    if(i % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(i);
                    }
                }
                Console.ResetColor();
            }
        }
    }
}
