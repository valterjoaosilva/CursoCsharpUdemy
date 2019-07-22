using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double lado = 2.5;
            double quadrado = lado * lado;
            Console.WriteLine(quadrado);
            Console.WriteLine("A área do quadrado é " + quadrado);
            Console.WriteLine("área do quadrado é  " + quadrado  + 12);
            Console.WriteLine("A área do quadrado é: " + (quadrado + 12));

            bool correndo = true;
            Console.WriteLine("O menino está correndo? " + correndo);

            int joao = 30;
            int carlos = 35;
            int idadeGrupo = joao + carlos;
            Console.WriteLine("idade do grupo é :" + idadeGrupo);

            float precoDoComputador = 2350.45f;
            Console.WriteLine("preço do computdor " + precoDoComputador);

            char letra = 'b';
            Console.WriteLine("a letra é " + letra);

            string palavra = "valter é o nome dele";
            Console.WriteLine("palavra é " + palavra);


        }
    }
}
