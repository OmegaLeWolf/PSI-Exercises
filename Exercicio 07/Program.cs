using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Programa calculadora-----\n");
            Console.WriteLine("Insira dois valores inteiros: ");

            Console.Write("\t1º valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t2º valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha a opção que pretende: ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|  1 - Soma                     |");
            Console.WriteLine("|  2 - Subtração                |");
            Console.WriteLine("|  3 - Multiplicação            |");
            Console.WriteLine("|  4 - Divisão                  |");
            Console.WriteLine("|  5 - Divisão Inteira          |");
            Console.WriteLine("|  6 - Resto da Divisão Inteira |");
            Console.WriteLine("---------------------------------");

            int.TryParse(Console.ReadLine(), out int op);
            
            switch(op)
            {
                case 1:
                    Console.WriteLine("O resultado da soma entre {0} e {1} é: {2}", n1, n2, n1 + n2);
                    break;
                case 2:
                    Console.WriteLine("O resultado da subtração entre {0} e {1} é: {2}", n1, n2, n1 - n2);
                    break;
                case 3:
                    Console.WriteLine("O resultado da multiplicação entre {0} e {1} é: {2}", n1, n2, n1 * n2);
                    break;
                case 4:
                    Console.WriteLine("O resultado da divisão entre {0} e {1} é: {2}", n1, n2, n1 / n2);
                    break;
                case 5:
                    Console.WriteLine("O resultado da divisão inteira entre {0} e {1} é: {2}", n1, n2, Convert.ToInt32(n1 / n2));
                    break;
                case 6:
                    Console.WriteLine("O resultado do resto da divisão inteira entre {0} e {1} é: {2}", n1, n2, n1 % n2);
                    break;
            }
            Console.ReadKey();
        }
    }
}
