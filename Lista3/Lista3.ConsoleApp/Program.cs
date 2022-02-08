using System;

namespace Lista3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i < 500; i++)
            {
                if (i % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
                Console.ResetColor();
            }
        }
    }
}
