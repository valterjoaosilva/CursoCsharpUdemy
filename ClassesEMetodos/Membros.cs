using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa(); // new pessoa é o construtor Pessoa é o tipo sicrano é nome da varieável 
            sicrano.Nome = "Valter João ";
            sicrano.Idade = 50;

            Console.WriteLine($"{sicrano.Nome}, tem {sicrano.Idade}, anos");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Samira Regina";
            fulano.Idade = 45;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
               
        }
    }
}
