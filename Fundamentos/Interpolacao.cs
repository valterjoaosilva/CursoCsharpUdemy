using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Valter João";
            var idade = 50;
            string ocupacao = "Estudante";
            Console.WriteLine("nome " + nome + " sua idade é :" + idade + " anos,  Atualmente é : " + ocupacao + ".");
            Console.WriteLine("nome  {0}  sua idade é : {1}  atualmente é : {2}.", nome, idade, ocupacao);
            Console.WriteLine($"nome  {nome} sua idade é {idade} atualmente é {ocupacao}.");
            Console.WriteLine($" 234 + 22 = {234 +22}");
        }
    }
}
