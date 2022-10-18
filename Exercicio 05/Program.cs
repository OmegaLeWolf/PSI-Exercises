using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Programa de precessamento de salários---");

            Console.Write("Nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("{0}, insira o valor das vendas que efetuou: ", nome);
            if (Double.TryParse(Console.ReadLine(), out double vendas) == false)
            {
                Console.WriteLine("Opção inválida");
                return;
            }
            Console.WriteLine("Valor da comissão: {0}", vendas * 0.05);
            double imposto = 0;
            if ((vendas * 0.05) <= 500) { imposto = (vendas * 0.05) * 0.1; Console.WriteLine("Valor do imposto: {0}", imposto); }

            else if ((vendas * 0.05) > 500 && (vendas * 0.05) <= 899) { imposto = (vendas * 0.05) * 0.15; Console.WriteLine("Valor do imposto: {0}", imposto); }

            else if ((vendas * 0.05) >= 900) { imposto = (vendas * 0.05) * 0.2; Console.WriteLine("Valor do imposto: {0}", imposto); }

            Console.WriteLine("Valor a receber: {0}", (vendas * 0.05) - imposto);

            Console.ReadKey();

        }
    }
}
