using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; // nesse caso declaramos e inicializamos uma variável sem dizer o tipo, por que por inferência o C# sharp já faz isso, para isso tem que declarar e inicializar antes.
            var idade = 49;
            Console.WriteLine(nome + idade);

            int a; // isto é declarar a variável
             a = 345; // isso é declarar e inicializar, dar valor a variável.
            Console.WriteLine(a);
            



        }
    }
}
