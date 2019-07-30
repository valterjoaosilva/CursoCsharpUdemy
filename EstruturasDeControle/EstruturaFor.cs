using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            /* double soma = 0;

             Console.WriteLine("Digite o tamanho da turma: ");
             int.TryParse(Console.ReadLine(), out int tamanhoTurma);

             for (int i = 1; i <= tamanhoTurma; i++)
             {
                 Console.WriteLine("Digite a nota do Aluno: ");
                 Double.TryParse(Console.ReadLine(), out double nota);
                 soma = soma + nota;
             }
             double media = soma / tamanhoTurma;

             Console.WriteLine($"Média é: {media}");*/

            double soma = 0;

            Console.Write("Digite o nome do Aluno: ");
            string aluno = Console.ReadLine();

            Console.Write("Quantas notas serão lançadas? ");
            int.TryParse(Console.ReadLine(), out int qdNotas);

            for (int i = 1; i <= qdNotas; i++)
            {
                Console.WriteLine( "Digite a nota do aluno");
                Double.TryParse(Console.ReadLine(), out double notas);

                soma = soma + notas;
            }
            double media = soma / qdNotas;

            Console.WriteLine($"Média do Aluno {aluno}, é: {media}");
        }
    }
}
