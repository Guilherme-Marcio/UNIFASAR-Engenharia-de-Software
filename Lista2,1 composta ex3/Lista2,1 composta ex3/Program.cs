using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_1_composta_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é de maior");
            }
            else
            {
                Console.WriteLine("Você é de menor");
            }
        }
    }
}
