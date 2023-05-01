using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAtribuicao {
    class Program {
        static void Main(string[] args) {
            // OPERADORES DE ATRIBUIÇÃO:

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            //FUNCIONA COM STRING TAMBÉM: 
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            // OPERADORES ARITMÉTICOS 
            // ++ significado a + 1
            // --

            int b = 10;
            b++;
            int c = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
