using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            string nome = "Valter João ".ToUpper().Insert(12,  "  da Silva Junior").Replace("da Silva Junior", "lindo");
            Console.WriteLine(nome);

            string prenome = "Valter João ".ToUpper().Insert(12, "da Silva Junior");
            Console.WriteLine(prenome);

            string valorImportante = null; // no caso de variável vazia não funciona notação ponto, para funcionar colocamos ?
            Console.WriteLine(valorImportante?.Length);


        }
    }
}
