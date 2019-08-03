using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // metodo estático (static) não precisa instanciar para ser chamado. Apena se define a variavel que recebe a classe
        public static int Somar(int a, int b)
        {
            return a + b;
        } 
        // método não estático, precisa ser instanciado para ser chamado(new nomedaclasse)
        public int Multiplicar(int c, int d)
        {
            return c * d;
        }
    }
    class MetodoEstatico
    {
        public static void Executar()
        {
            // Construtor estático sem new, método é estático (static).
            var somatorio = CalculadoraEstatica.Somar(3, 4);
            Console.WriteLine(somatorio);
            CalculadoraEstatica multiplica = new CalculadoraEstatica();
            Console.WriteLine(multiplica.Multiplicar(3, 4));

        }
    }
}
