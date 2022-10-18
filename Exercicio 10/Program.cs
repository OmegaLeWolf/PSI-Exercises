using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa de Números Primos-----");
            Console.Write("\nInsira um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true)
            {
                Console.WriteLine("O número {0} é um número primo.", n);
            }

            else
            {
                Console.WriteLine("O número {0} não é um número primo.", n);
            }

            Console.ReadKey();
        }
    }
}
