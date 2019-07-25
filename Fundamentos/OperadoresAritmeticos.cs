using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // operações padrões 

            var preco = 234.56;
            var imposto = 1.05;
            var lucro = 1.10;
            var desconto = 0.2;
            var total = ((preco * lucro) * (imposto)) - (((preco * lucro) * (imposto)) * desconto);
            Console.WriteLine("Valor total é: {0}", total);

            // calculo

            var raio = 3.5;
            var lado = 4.2;
            const double pi = 3.14;
            var area = Math.Pow(raio, 2) * pi;
            var quadrado = Math.Pow(lado, 2);
            Console.WriteLine($"A área do Raio é: {area} área do quadrado é: {quadrado}");

            int valor1 = 4;
            int valor2 = 7;
            int valorPar = valor1 % 2;
            int valorImpar = valor2 % 2;
            Console.WriteLine("valor par: {0} valor impar: {1}", valorPar, valorImpar);




        }
    }
}
