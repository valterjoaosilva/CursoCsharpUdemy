using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 5.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

            Console.Write("Digite a nota");
            int nota1 = int.Parse(Console.ReadLine());
            bool bomComportamento1 = true;

            string resultado1 = nota1 >= 7.0 && bomComportamento1 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado1);

        }
    }
}
