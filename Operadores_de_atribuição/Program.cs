using System;

namespace Operadores_de_atribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            a recebe 10
            */ 
            int a = 10;
            Console.WriteLine(a);
            
            /*
            a mais 2
            */
            a += 2;
            Console.WriteLine(a);

            /*
            Vai multiplicar por 3
            */
            a *= 3;
            Console.WriteLine(a);

            /*
            variavel recebe string
            */
            string s = "ABC";
            Console.WriteLine(s);

            /*
            Váriavel s com valor ABC recebe DEF
            */
            s += "DEF";
            Console.WriteLine(s);

            /*
            Operador aritmético / atribuição
            */

            int x = 10;
            x++;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            /*
            z recebe 10 do x, e dai incrementa com o ++, resultado vai ser 11
            */
            int z = x++;
            Console.WriteLine(z);
            /*
            Nesse caso ele vai incrementar a variavel antes
            */
            int y = ++x;
            Console.WriteLine(y);
        }
    }
}
