﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 2;
            num1 /= 3;
            Console.WriteLine("Numero 1 é: {0}",  num1);


            int a = 1; 
            int b = a; // 

            a++;// a = a + 1
            a--;//a = a - 1

        }
    }
}
