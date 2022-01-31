/*8 - Entrar com um número maior que 50, verificar quantos números pares existem de 1 até o número escolhido.
Solicitar ao usuário para escolher qual posição dos números “pares” o mesmo deseja imprimir.*/

using System;
using System.Collections.Generic;

namespace exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pares = new List<int>();
            Console.WriteLine("informe um número maior que 50.");
            int valor = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 1; i < valor; i++)
                {
                    if  (i % 2 == 0)
                    {
                        pares.Add(i);
                    }
                }
            Console.WriteLine("qual primeiro numero intervalo deseja imprimir?");

            int intervalo_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("qual segundo numero intervalo deseja imprimir?");

            int intervalo_2 = Convert.ToInt32(Console.ReadLine());
            var numerosIntervalo =  pares.GetRange(intervalo_1, intervalo_2);

            Console.WriteLine(numerosIntervalo);
            

        }
    }
}
