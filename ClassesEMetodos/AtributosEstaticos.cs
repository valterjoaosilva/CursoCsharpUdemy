using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)// construtor especifico
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto; 
        }
        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()//construtor padrão
        {
            var produto1 = new Produto("Camisa", 55.4, 0.05);
            var produto2 = new Produto()
            {
                Nome = "Camiseta",
                Preco = 44.6,
               
            };
            Produto.Desconto = 0.5;
            Console.WriteLine("O preço do produto é {0}", produto1.CalcularDesconto());
            Console.WriteLine("O preço do produto é {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;
            Console.WriteLine("O preço do produto é {0}", produto1.CalcularDesconto());
            Console.WriteLine("O preço do produto é {0}", produto2.CalcularDesconto());

        }
    }
}
