/*2 - Faça um programa que aceite somente números entre 1 e 10.
    Uma vez aceito o número, imprima a tabuada de multiplicação de 1 até 10.*/

using System;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um número de 1 a 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0 && numero <= 10)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero * i);
                }
            }    else
            {
                Console.WriteLine("por favor, digite um numero que esteja no intervalo de 1 a 10");
            }

        }
    }
}
