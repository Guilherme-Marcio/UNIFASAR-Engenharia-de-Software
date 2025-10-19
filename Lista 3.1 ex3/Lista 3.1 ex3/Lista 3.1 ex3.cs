using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3._1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta;

            Console.WriteLine("Digite o valor do coeficiente A");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do coeficiente B");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do coeficiente C");
            C = double.Parse(Console.ReadLine());

            if (A == 0)
            {
                Console.WriteLine("O valor A não pode ser = 0");
            }
            else {
                delta = (B * B) - 4 * A * C;

                if (delta < 0)
                {
                    Console.WriteLine("Não existem raízes reais para esta equação.");
                }

                else { }



                }
    }
}
