using System;

namespace Conversao_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Conversão implicita de tipos
             É possivel pq float tem 4 bytes e double tem 8 bytes
             O cobntrario da problema
             */
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            /*
             Para fazer a conversão de forma correta
             Pode jogar a informação dentro da outra variavel
             */
            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            /*
             Para fazer a conversão de de double para inteiro
             Vai ter perda de informação por ser uma variável inteira. Os valores depois da virgula serão truncados.
             */
            double h;
            int v;

            h = 5.1;
            v = (int)h;
            Console.WriteLine(v);

            /*
             O compilador nesse caso faz uma divisao inteira
             para garantir que o resultado seja double, se deve colocar em casting
             */

            int l = 5;
            int z = 2;

            double resultado = l / z;
            Console.WriteLine(resultado);

            double resultado2 = (double)l / z;
            Console.WriteLine(resultado2);
        }
    }
}
