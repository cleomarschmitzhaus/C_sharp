using System;

namespace Operadores_aritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - * / % são executados antes de + e -
            3 + 4 * 2 =  11, pq se faz 4 x 2 + 3
            para executar o + e - antes, deve se colocar em parenteses ( 3 + 4 ) * 2 = 14
            % o resto do resultado
            */

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            /*
             Se colocar o valor como 10.0 o compilador tambem entende que é um valor double, ao menos um dos dois.
             */

            double n4 = (double)10 / 8;
            Console.WriteLine(n4);

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            /* tambem pode ser usado: double delta = Math.Pow(b, 2.0) - 4.0 * a * c;*/

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
        }
    }
}
