using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine( quebrado);

            double nota = 8.9; // conversões de tipos (variáveis menores para maiores pode ser feita sem especificar nada.
            int notaTruncada = (int) nota;
            Console.WriteLine(notaTruncada);

            double nota1 = 8.9; /*conversões de tipos maiores para menores podem ser feitas porém tem que especificar 
            o tipo e vai peder informações no caso de ponto flutante para inteiro*/
            int notaTruncada1 = (int)nota1;
            Console.WriteLine($"Nota Truncada {notaTruncada1}");// aqui treinando interpolação.

            Console.Write("digite sua idade: ");
            string idadeString = Console.ReadLine();/*Convertendo uma string vindo do teclado em um inteiro, lembrando
            sempre que vir do teclado vira uma string por isso se precisar 
            ser do tipo inteiro tem que converter.*/
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade é: {0}", idadeInteiro);

            Console.Write("Digite a sua idade: ");
            string idade1 = Console.ReadLine();//outro tipo de conversão usando Convert
            int idade2 = Convert.ToInt32(idade1);
            Console.WriteLine("Idade é:" +idade2 );

            // agora vamos jogar uma string dentro de uma variável número, valor vindo do teclado
            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"O número é: {numero1}");

            // melhorando o código
            Console.WriteLine("Digite um número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O númro é: {0}", numero2);



        }
    }
}
