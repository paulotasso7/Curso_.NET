/*8) Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles.
*/

using System;

namespace exerciciosIniciais_8
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
                Console.WriteLine("o maior numero é: " + primeiro);
            }
            else if (primeiro < segundo)
            {
                Console.WriteLine("o maior numero é: " + segundo);
            } else
            {
                Console.WriteLine("Por favor, informe dois numeros distintos");
            }
        }
    }
}
