using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_1_composta_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resto;
            Console.WriteLine("Digite um numero inteiro positivo:");
            numero = int.Parse(Console.ReadLine());

            resto = numero % 2;

            if (resto == 0)
            {
                Console.WriteLine("O número é par");
            }

            else
            {
                Console.WriteLine("O número é impar");
            }

        }
    }
}
