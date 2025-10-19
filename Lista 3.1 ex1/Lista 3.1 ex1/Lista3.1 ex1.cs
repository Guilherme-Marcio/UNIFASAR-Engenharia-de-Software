using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3._1_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;

            Console.WriteLine("Digite o peso da mochila em Kg:");
            peso = double.Parse(Console.ReadLine());

            if (peso < 5)
            {
                Console.WriteLine("Mochila leve");
            }
                else if (peso >= 5 && peso <= 10)
                {
                Console.WriteLine("mochila pesada");
                }

            else { Console.WriteLine("Mochila muito pesada"); }

        }
    }
}
