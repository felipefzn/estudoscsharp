using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int resultado = n1 + n2;
            double n4 = (double)10.0 / 8; //se fizer uma expressão que vai dar numero quebrado, com numeros inteiros o compilador vai colocar
                                          //o resultado em int. pra arrumar isso, colocar o (double) na frente ou transformar o numero em decimal ex: 10.0

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;//esse Math.Pow representa um expoente, que dizer que o B é elevado a 2.0

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // isso é basicamente baskara. esse Math.Sqrt é pra fazer raiz quadrada
            
            Console.WriteLine(delta);
            Console.WriteLine(x1);

            

            Console.WriteLine("A soma dos numeros: "+n1+" e "+n2+" é igual a : "+resultado);
        }
    }
}
