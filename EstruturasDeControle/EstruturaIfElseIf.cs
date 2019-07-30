using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0 && nota < 10.1)
            {
                Console.WriteLine("Foi Aprovado  e entrou para o quadro de honra");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
            Console.WriteLine("Fim da Edição");
        }
    }
}
