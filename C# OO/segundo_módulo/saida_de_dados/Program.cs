using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia");//console.writeline tem uma quebra de linha no final
            Console.Write("Boa tarde!");
            Console.Write("teste");//só console.write não tem a quebra de linha do final, fica tudo um do lado do outro

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine(saldo.ToString("F2"));//esse .ToString("F2") serve pra limitar a quantidade de casas decimais
                                                    //F2 - limita 2, F3 - limita 3 e por assim vai
            Console.WriteLine(saldo.ToString("F4"));//imprimiu com 4 casas decimais, detalhe que quando vc limita ele arredeonda o numero
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//esse CultureInfo.InvariantCulture, ele ignora qualquer tipo de formatação especifica de país, ou seja nesse caso troca a virgula pelo ponto
                                                                                  // pra usar esse CultureInfo.InvariantCulture precisa colocar lá encima using System.Globalization;         

            Console.WriteLine("-------------------------------------------------------");

            int Idade = 18;
            double Saldo = 10.35785;
            string Nome = "Felipe";

            Console.WriteLine("{0} tem {1} anos e tem saldo = {2:F2} reais", Nome, Idade, Saldo);//método placeholder, esse 2:F2 é o mesmo esquema de limitar os numeros decimais

            Console.WriteLine($"{Nome} tem {Idade} anos e tem saldo = {Saldo:F2} reais");//método interpolação, só colocar o $ no cmc, e colocar o nome das var em {}

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");//método concatenação
        }
    }
}
