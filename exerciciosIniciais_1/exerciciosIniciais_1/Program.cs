/*Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B.

A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o

valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados

nas variáveis.*/


using System;

namespace exerciciosIniciais_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;
            int C = A;

            
            A = B;
            B = C;
            Console.WriteLine("Valor de A :" + A);
            Console.WriteLine("Valor de B :" + B);
            
        }
    }
}
