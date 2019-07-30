using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            do
            {
                
                Console.WriteLine("Qual o seu nome?");
                var corAntiga = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                entrada = Console.ReadLine();
                Console.BackgroundColor = corAntiga;
               

                Console.WriteLine("Seja bem vindo");
                corAntiga = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Você deseja continuar? (S/N)");
                entrada = Console.ReadLine();
                Console.BackgroundColor = corAntiga;

            } while (entrada.ToLower() == "s");
        }
    }
}
