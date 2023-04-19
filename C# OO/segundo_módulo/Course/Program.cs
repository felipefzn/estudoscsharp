using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Course {
    class Program {
        static void Main(string[] args) {

          /*  byte n1 = 255;
            int n2 = 1000;

            int n3 = 2147483647;
            long n4 = 2147483648L; //colocar o L no final pra expressar que está usando a variavel long, sempre que utliza-la 

            bool completo = false;
            char genero = 'F';//
            float n5 = 4.5f;//pra criar uma var float, precisa colocar o f no final, pra mostrar que é float
            double n6 = 4.5;
            string nome = "Felipe"; //pra string usar aspas duplas "" | var strind é imutavel, assim que vc coloca o valor nela, n consegue alterar 
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3); //escrever cw e aperta tab tab ele escreve esse código, porém é sempre bom manter o habito de escrever, pra manter os bons costumes
            Console.WriteLine(n4);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);*/

            //---------------------------------------------

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            sbyte n4 = sbyte.MaxValue;
            decimal n5 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            Console.Write("pegar a mãe do barcos aqui");


        }
    }
}

//os primeiros 8 tipos são pra número inteiro, unica dif é se são com sinal ou sem sinal
//mais utilizados: int e long
//tipos ponto flutuante, double e float |  aceitam numeros quebrados com casas decimais 
//decimal utiliza 12 bytes e é usado para calculos complexos
//char aceita um caracter universal
//boolean = true ou false

//byte não aceita número negativo