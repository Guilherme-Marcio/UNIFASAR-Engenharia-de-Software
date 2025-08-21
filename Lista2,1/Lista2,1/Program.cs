using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite um número inteiro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Os valores são iguais");
            }

            if (a > b)
            {
                Console.WriteLine("O valor " + a + " é maior que o valor " + b);
            }

            if (a < b)
            {
                Console.WriteLine("O valor " + b + " é maior que o valor " + a);
            }


        }
    }
}
