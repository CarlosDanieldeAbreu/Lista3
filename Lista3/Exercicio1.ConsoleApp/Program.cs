using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string AlturaPessoa = "";
            float maiorPessoa = -9999;
            float menorPessoa = 9999;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a altura:");
                AlturaPessoa = Console.ReadLine();
                float Altura = Convert.ToSingle(AlturaPessoa);

                if (Altura < menorPessoa)
                {
                    menorPessoa = Altura;
                }
                if (Altura > maiorPessoa)
                {
                    maiorPessoa = Altura;
                }
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("A maior pessoa é a de " + maiorPessoa + "M de altura");
            Console.WriteLine("====================================================");
            Console.WriteLine("A menor pessoa é a de " + menorPessoa + "M de altura");
        }
    }
}
