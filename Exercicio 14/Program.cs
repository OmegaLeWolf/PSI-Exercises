using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Apresentação de números positivos-----");
            int j = 0;
            int k = 0;

            double n;
            do
            {
                Console.WriteLine("\nDigite um número ('0' para terminar): ");
                
                n = Convert.ToDouble(Console.ReadLine());
                if (n > 0)
                {
                    
                    j++;
                }
                else if (n < 0)
                {
                    
                    k++;
                }
                else
                {
                    break;
                }
            }
            while (n != 0);
            Console.Write("\nDigitou {0} número(s) positivo(s)", j);
            Console.WriteLine(" e {0} número(s) negativo(s)", k);
            Console.ReadKey();
        }
    }
}
