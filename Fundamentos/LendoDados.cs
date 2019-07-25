using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu país de origem? ");
            string pais = Console.ReadLine();

            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Quantos filhos você tem? ");
            int qtFilhos = int.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você tem? ");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{pais} {nome} {qtFilhos} {dolar}");
        }
    }
}
