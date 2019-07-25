﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("comprou a TV 50? {0}", comprouTv50 );

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("comprou a TV 32? {0}", comprouTv32);

            Console.WriteLine("É mais saudável? {0}", ! comprouSorvete);


        }
    }
}
