using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
           double salario = 345.454;
            Console.WriteLine(salario.ToString("F"));
            Console.WriteLine(salario.ToString("C"));
            Console.WriteLine(salario.ToString("P"));
            Console.WriteLine(salario.ToString("#.##"));
            Console.WriteLine(salario.ToString("C3"));


            int inteiro = 400;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
