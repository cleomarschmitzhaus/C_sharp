using System;
using System.Globalization;


namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /* Produto:
             Computador, cujo preço é $ 2100,00
             Mesa de escritório, cujo preco é $ 650,50
            
             Registro: 30 anos de idade, código 5290 e generos: M
            
             Medida com oito casas decimais: 53,23456700
            Arredondando (Três casas decimais): 53,235
            Separador decimal Invariant Culture: 53.235*/

            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}. cujo preço é $ {preco2}");
            Console.WriteLine($"Registro {idade} anos de idade, código {codigo} e genero {genero}");
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine($"Arredondando (Três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal Invariant Culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
