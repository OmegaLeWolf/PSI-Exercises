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
            int k = 0;
            int l = 0;
            Console.WriteLine("Quantos valores pretende introduzir? ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nDigite um {0} número: ", i + 1);
                string n = Console.ReadLine();
                if (Convert.ToDouble(n) > 0)
                {
                    Console.WriteLine("{0} é um número positivo", n);
                    j++;
                }
                else if (Convert.ToDouble(n) < 0)
                {
                    Console.WriteLine("{0} é um número negativo", n);
                    k++;
                }
                else
                {
                    Console.WriteLine("{0} é um número neutro", n);
                    l++;
                }
            }
            Console.WriteLine("\nDigitou {0} número(s) positivo(s)", j);
            Console.WriteLine("Digitou {0} número(s) negativo(s)", k);
            Console.WriteLine("Digitou {0} número(s) neutro(s)", l);
            Console.ReadKey();
        }
    }
}
