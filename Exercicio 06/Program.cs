using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a nota?");
            if (Double.TryParse(Console.ReadLine(), out Double nota))
            {
                nota = Math.Round(nota);

                switch (nota)
                {
                    case 0: case 1: case 2: case 3: case 4: Console.WriteLine("Mau"); break;
                    case 5: case 6: case 7: case 8: case 9: Console.WriteLine("Medíocre"); break;
                    case 10: case 11: case 12: case 13: Console.WriteLine("Suficiente"); break;
                    case 14: case 15: case 16: case 17: Console.WriteLine("Bom"); break;
                    case 18: case 19: case 20: Console.WriteLine("Excelente"); break;

                    default: Console.WriteLine("Nota inváida"); break;
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não é um número.");
                Console.ReadKey();
            }
        }
    }
}
