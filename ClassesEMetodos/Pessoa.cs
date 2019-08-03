using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; //atributo publico
        public int Idade; //atributo publico

        public string Apresentar()
        {
            return string.Format($"Óla e meu chamo {Nome}, e tenho {Idade}, anos. ");

        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        
    }
}
