using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Aplicação calculo média peso----\n\n");

            string name = "";
            double weight = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Insira o seu {i}º nome: ");

                name = name + " " + Console.ReadLine();
            }

            Console.WriteLine("Insira o seu peso nos últimos 5 meses");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"\tMês {i}: ");
                weight = weight + Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"{name}, a média do seu peso é {weight/2}");
            Console.ReadLine();
        }
    }
}
