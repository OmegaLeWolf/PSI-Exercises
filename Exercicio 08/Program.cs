using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Apresentação de números positivos-----");
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um {0} número: ", i+1);
                string n = Console.ReadLine();
                if (Convert.ToDouble(n) > 0)
                {
                    Console.WriteLine("{0} é um número positivo", n);
                    j++;
                }
            }
            Console.WriteLine("Digitou {0} número(s) positivo(s)", j);
            Console.ReadKey();
        }
    }
}
