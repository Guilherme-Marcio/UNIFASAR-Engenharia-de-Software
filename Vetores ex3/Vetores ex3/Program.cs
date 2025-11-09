using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_ex3
{
    internal class Program
    {
        static double[] Combinador(double[] a, double[] b)
        {
            double[] combinacao = a.Concat(b).ToArray();

            return combinacao;
        }

        static void Main(string[] args)
        {
            double[] a = new double[3];
            double[] b = new double[3];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor do vetor A ");
                a[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o {i + 1}º valor do vetor B ");
                b[i] = double.Parse(Console.ReadLine());

            }
            double[] c = Combinador(a, b);
            string resultado = String.Join("/", c);

            Console.WriteLine($"Vetor Combinado:[ {resultado} ]");
        }
    }
}
