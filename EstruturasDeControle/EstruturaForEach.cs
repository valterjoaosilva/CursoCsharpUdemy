﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "valtrer";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);

                var alunos = new string[] { "ana", "Bia", "Julia" };

                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

            }
        }
    }
}
