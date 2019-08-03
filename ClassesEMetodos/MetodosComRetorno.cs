using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int c, int d)
        {
            return c - d;
        }
        public int Multiplicar(int e, int f)
        {
            return e * f;
        }
        public int Divisao(int g, int h)
        {
            return g / h;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Soma(5,  3);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(135, 32));
            Console.WriteLine(calculadoraComum.Multiplicar(10, 2));
            Console.WriteLine(calculadoraComum.Divisao(4, 2));

        }
    }
}
