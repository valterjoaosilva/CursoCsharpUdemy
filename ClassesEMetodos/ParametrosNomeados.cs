using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Formatar(dia: 2, mes: 3, ano: 2013);
            Formatar(ano: 2004, dia: 30, mes: 2);//pode colocar fora de ordem que o c# sharp corrigi.
            Formatar(2, 3, 2018);//nesse caso você precisa colocar em ordem, assim como foi escrito nesse caso
            Formatar(2019, 3, 2);// vai retornar com está aqui, não vai colocar em ordem.
            

        }
    }
}
