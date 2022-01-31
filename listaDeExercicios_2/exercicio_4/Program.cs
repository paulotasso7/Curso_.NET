//4 - Faça um programa que aceite somente números do intervalo de 10 a 20.
//Você poderá digitar quantos números quiser, porém caso você digite 6 números
//que esteja dentro desse intervalo o programa finaliza.

using System;
using System.Collections.Generic;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();   

            do
	        {
                Console.WriteLine("escreva um numero entre 10 e 20");
                int valorDado = Convert.ToInt32(Console.ReadLine());    
                if (valorDado >10 && valorDado < 20)
	            {
                    list.Add(valorDado);
	            }
	        } while (list.Count < 6);



        }
    }
}
