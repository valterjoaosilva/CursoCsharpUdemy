using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaprovacao = 7.0;

            Console.WriteLine("nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Aprovado com louvor? {0}", nota == 10.0);
            Console.WriteLine("Aprovado? {0}", nota >= 7.0);
            Console.WriteLine("Ficou em Recuperação? {0}", nota < 7.0);
            Console.WriteLine("Reprovado? {0}", nota < 3.0);

            Console.WriteLine("Qual é a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota1 );

            Console.WriteLine("nota inválida? {0}", nota1 > 10.0);
            Console.WriteLine("Aprovado com louvor? {0}", nota1 == 10.0);
            Console.WriteLine("Aprovado? {0}", nota1 >= 7.0);
            Console.WriteLine("Ficou em Recuperação? {0}", nota1 < 7.0);
            Console.WriteLine("Reprovado? {0}", nota1 < 3.0);





        }
    }
}
