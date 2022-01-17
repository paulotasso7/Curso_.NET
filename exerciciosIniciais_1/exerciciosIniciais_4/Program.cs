/*4) Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso

contrário escrever NÃO É MAIOR QUE 10!*/

using System;

namespace exerciciosIniciais_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número");
            int primeiro = Convert.ToInt32(Console.ReadLine());
            
            if(primeiro > 10) {
                Console.WriteLine(primeiro + " É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine(primeiro + " NÃO É MAIOR QUE 10!");
            }

        }
    }
}
