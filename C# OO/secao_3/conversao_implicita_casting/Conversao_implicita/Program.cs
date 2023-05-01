using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_implicita {
    class Program {
        static void Main(string[] args) {
            float a = 4.5f;
            double b = a;
            //Essa expressão pode ocorrer pois float vale 4bytes e double vale 8

            double c;
            float d;

            c = 5.1;
            d = c;
            //Ele não deixa pois 8bytes não entram em 4bytes, nesse caso você pode perder informação

            //casting:
            //basicamente você coloca o (tipo de var)antes da variavel , como mostra o exemplo abaixo

            double e;
            float f;

            e = 5.1;
            f = (float)e;
            Console.WriteLine(f);

            int g = 5;
            int h = 2;

            double resultado = (double)g / h; //sem o (double), ele vai dar print na tela 2, não do número quebrado, pois as var são int. Dai se vc coloca o double, ele garante que o resultado, caso for numero quebrado, vai vir corretamente, sem perder info
            Console.WriteLine(resultado);
        }
    }
}
