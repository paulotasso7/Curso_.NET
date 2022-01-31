/*6 - Digite a quantidade de alunos de uma turma, digite notas para cada aluno.
    No final imprima a nota média da turma.*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual tamanho da turma?");

            int turma = Convert.ToInt32(Console.ReadLine());

            List<double> listaNotas = new List<double>();

            for (int i = 0; i < turma; i++)
            {
                Console.WriteLine("digite uma nota");
                double notas = Convert.ToDouble(Console.ReadLine());
                listaNotas.Add(notas);
              
            }
            double somaNotas = listaNotas.Sum();
            var media = (somaNotas / turma).ToString("F");
            Console.WriteLine("nota média da turma: " + media);
        }
    }
}
