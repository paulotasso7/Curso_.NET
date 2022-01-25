/*3 - Faça um algoritmo que você entre com 5 números, no final imprima a quantidade
de números que foram menor que 0.*/

using System;
using System.Collections.Generic;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number");

                int arg = Convert.ToInt32(Console.ReadLine());

                if (arg < 0)
                {
                    list.Add(arg);
                }
            }

            Console.WriteLine("tamanho da lista é: " + list.Count);       

        }
    }
}
