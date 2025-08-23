using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preçokg, preçoref;

            Console.WriteLine("Digite o valor do KG:");
            preçokg = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso em KG da refeição:");
            preçoref = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor a ser pago é " + preçoref * preçokg);

            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.Read();
        }
    }
}
