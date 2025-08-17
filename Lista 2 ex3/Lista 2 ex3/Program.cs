using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            Console.WriteLine("Digite o raio do circulo:");
            raio = double.Parse(Console.ReadLine());
            area = 3.14 * (Math.Pow(raio, 2));

            Console.WriteLine("A área do circulo é " + area);

            Console.WriteLine("Digite qualquer teclao para fechar..");
            Console.ReadLine();


        }
    }
}
