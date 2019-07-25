using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Aluno possui bom comportamento? [S/N)");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada == "s")
            {
                bomComportamento = true;
            }
           s
            if (nota >= 6.0 && nota < 9.0 && bomComportamento)
            {
                Console.WriteLine("Aluno Aprovado");
            }

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Aluno entrou para o quadro de honra");
            }
            if(nota < 7 || !bomComportamento)
            {
                Console.WriteLine("Aluno Reprovado");
            }

        }
    }
}
