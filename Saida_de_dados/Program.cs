using System;
using System.Globalization;

namespace Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 34;
            double saldo = 10.35784;
            string nome = "Gisele";

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("---------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            /* Concatenação de informações */

            int idade2 = 34;
            double saldo2 = 10.35784;
            string nome2 = "Gisele";

            /* PlaceHolder */
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2);
            
            /* Interpolação */

            Console.WriteLine($"{nome2} tem {idade2} anos e tem saldo de {saldo2:F2} reais.");

            /* Concatenação de string */

            Console.WriteLine(nome2 + " tem " + idade2 + " anos e tem saldo de " + saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
