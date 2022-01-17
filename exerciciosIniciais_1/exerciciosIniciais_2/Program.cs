/*Escreva um algoritmo para ler um valor (do teclado) e escrever(na tela) o seu antecessor.
*/


using System;

namespace exerciciosIniciais_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoEntrada = "escreva um numero";
            Console.WriteLine(textoEntrada);
            int antecessor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(antecessor - 1);
            
        }
    }
}
