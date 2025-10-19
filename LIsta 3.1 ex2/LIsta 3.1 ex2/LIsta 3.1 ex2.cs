using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIsta_3._1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo, credito, debito;

            Console.WriteLine("Digite o valor de seu saldo.");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser depositado");
            credito = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a descontado");
            debito = double.Parse(Console.ReadLine());

            saldo += +credito - debito;

            if (saldo < 0)
            {
                Console.WriteLine("O seu saldo é de R$" + saldo);
                Console.WriteLine("O seu saldo é negativo");
            }

            else if (saldo == 0)
            {
                Console.WriteLine("O seu saldo é de R$" + saldo);
                Console.WriteLine("O seu saldo é nulo");
            }

            else
            {
                Console.WriteLine("O seu saldo é de R$" + saldo);
                Console.WriteLine("O seu saldo é positivo");
            }
        }
    }
}
