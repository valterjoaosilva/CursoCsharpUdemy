using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public String Modelo;
        public String Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)// Criando um carro a partir de um construtor específico 
        {

            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();// criando um carro a partir de um construtor padrão
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 1997;
            Console.WriteLine($"{carro1.Fabricante}, {carro1.Modelo}, {carro1.Ano}");

            var carro2 = new Carro("Corsa", "Chevrolet", 2002);//Construtor especifico 
            Console.WriteLine($"{carro2.Fabricante}, {carro2.Modelo}, {carro2.Ano}");

            var carro3 = new Carro()//construtor padrão
            {
                Fabricante = "Volkswagen",
                Modelo = "Gol",
                Ano = 2018,
            };
            Console.WriteLine($"{carro3.Fabricante}, {carro3.Modelo}, {carro3.Ano}");
        }
        
    }
}
