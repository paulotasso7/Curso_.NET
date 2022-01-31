/*7 - Entre com um número e verifique se o mesmo é um número primo ou não.*/

using System;

namespace exercicio_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Esolha um número para testar se é primo: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Número não é primo.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("O número é primo.");
        }
    }
}