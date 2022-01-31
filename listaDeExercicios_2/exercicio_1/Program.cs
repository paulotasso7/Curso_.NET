using System;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um numero inteiro");
            int valorInicial = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int sequencia = valorInicial + i;
                Console.WriteLine(sequencia);
            }
        }
    }
}