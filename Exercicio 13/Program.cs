using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("----Gestão do Saldo----\n");
            Console.WriteLine("Digite o seu saldo: ");

            double money = Convert.ToDouble(Console.ReadLine());

            while (money > 0)
            {
                Console.WriteLine("Digite a quantia a levantar: ");
                double val = Convert.ToDouble(Console.ReadLine());

                money -= val;
            }
            Console.ResetColor();
            Console.WriteLine($"O seu saldo atual é {money} €");
            Console.ReadKey();
        }
    }
}
