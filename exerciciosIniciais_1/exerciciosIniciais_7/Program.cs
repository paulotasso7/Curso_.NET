/*7) Ler as notas da 1a.e 2a.avaliações de um aluno. Calcular a média aritmética simples e escrever

uma mensagem que diga se o aluno foi ou não aprovado (considerar que nota igual ou maior que 6 o

aluno é aprovado). Escrever também a média calculada.*/

using System;

namespace exerciciosIniciais_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota da primeira prova");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a nota da segunda prova");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            int media = (nota1 + nota2)/2;
            
            if(media >= 6) {
                Console.WriteLine("Parabéns, você foi aprovado com a média: " + media );
            } else {
                Console.WriteLine("Vamos estudar mais?! Sua média foi: " + media);
            }

        }
    }
}
