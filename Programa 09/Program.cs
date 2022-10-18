using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int valor;

            Console.WriteLine("-----Curiosidades------\n");

        //Label inicio

        inicio:
            Console.WriteLine("Insira um número entre 1 e 3: ");
            valor = Convert.ToInt32(Console.ReadLine());

            switch(valor)
            {
                case 1:
                    Console.WriteLine("Curiosidade 1");
                    break;
                case 2:
                    Console.WriteLine("Curiosidade 2");
                    break;
                case 3:
                    Console.WriteLine("Curiosidade 3");
                    break;
                default:
                    Console.WriteLine("O seu número não está entre 1 e 3");
                    break;
            }

        opcao:
            Console.WriteLine("Digite \"continuar\" para continuar a utilizar o programa ou \"sair\" para terminar o programa: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "continuar": goto inicio;
                case "sair": Console.WriteLine("Então adeus"); break;
                default: Console.WriteLine("Não digitou o que foi pedidio");
                    goto opcao;
            }
            Console.ReadLine();
        }
    }
}
