using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_1_composta_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valortv, valordvd, soma;

            Console.WriteLine("Qual o valor da TV 32”?");
            valortv = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do DVD?");
            valordvd = double.Parse(Console.ReadLine());

            soma = valordvd + valortv;

            if (soma <= 1300)
            {
                Console.WriteLine("Promoção");
            }

            else
            {
                Console.WriteLine("Sem promoção");
            }


        }
    }
}
