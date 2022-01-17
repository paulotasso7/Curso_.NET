/*5) Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo).
*/
using System;

namespace exerciciosIniciais_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoEntrada = "escreva um numero";
            Console.WriteLine(textoEntrada);
            int numeral = Convert.ToInt32(Console.ReadLine());
           if(numeral >= 0)
            {
                Console.WriteLine("Número POSITIVO");
            } else if(numeral < 0)
            {
                Console.WriteLine("Número NEGATIVO");
            }
        }
    }
}
