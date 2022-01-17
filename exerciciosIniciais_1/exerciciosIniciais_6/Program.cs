/*6) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem

compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e

escreva o custo total da compra.*/

using System;

namespace exerciciosIniciais_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas maçãs deseja?");
            int numeral = Convert.ToInt32(Console.ReadLine());
            if (numeral >= 12)
            {
                int totalDuzia = numeral * 1;
                Console.WriteLine("Total da compra: R$ " + totalDuzia);
            }
            else if (numeral < 12)
            {
                double totalMenorQueDuzia = Math.Round(numeral * 1.3, 2);
                Console.WriteLine("Total da compra: R$ " + totalMenorQueDuzia);
            }
        }
    }
}
