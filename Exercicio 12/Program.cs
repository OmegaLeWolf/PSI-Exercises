using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Voos Seguros---------");
            Console.WriteLine("----Reservas de passagens aéreas----");

            string[] nomes = new string[10];
            for (int i = 1; i < nomes.Length+1; i++)
            {
                Console.WriteLine($"Introduza o nome do {i}º passageiro: ");
                nomes[i - 1] = Console.ReadLine();
            }

            foreach(string nome in nomes)
            {
                Console.WriteLine($"Passageiro {Array.IndexOf(nomes, nome)+1}: {nome}");
            }
            Console.ReadKey();
        }
    }
}
