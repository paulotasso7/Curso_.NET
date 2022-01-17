/*Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a

área do retângulo.*/


using System;

namespace exerciciosIniciais_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a largura em centimetros");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o comprimento em centimentros");
            int comprimento = Convert.ToInt32(Console.ReadLine());
            int areaRetangulo = largura * comprimento;
            Console.WriteLine(areaRetangulo + "cm²");
        }
    }
}
