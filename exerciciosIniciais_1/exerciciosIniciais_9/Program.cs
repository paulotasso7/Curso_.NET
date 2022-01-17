using System;

namespace exerciciosIniciais_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número");
            int primeiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int segundo = Convert.ToInt32(Console.ReadLine());

            if (primeiro > segundo)
            {
                Console.WriteLine(segundo + " , " + primeiro);
            }
            else if (primeiro < segundo)
            {
                Console.WriteLine(primeiro + " , " + segundo);
            }
            else
            {
                Console.WriteLine("Por favor, informe dois numeros distintos");
            }
        }
    }
}
