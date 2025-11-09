using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_ex1
{
    internal class Program
    {
        static double[] RetornaSoma(double[] a, double[] b)
        {
            double[] c = new double[3];
            for (int i = 0; i < c.Length; i++) 
            {
                c[i] = a[i] + b[i];

            }

            return c;
        }
        static void Main(string[] args)
        {
            double[] a = new double[3];
            double[] b = new double[3];   

            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine($"Digite o {i + 1}º valor do vetor A: ");
                a[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o {i + 1}º valor do vetor B: ");
                b[i] = double.Parse(Console.ReadLine());

            }

              double[] c = RetornaSoma(a, b);

            /*
             Console.WriteLine($"{String.Join("/ ", c)}"); 
            */


            for (int i = 0; i < c.Length; i++)
             {
                 Console.WriteLine($"A soma do {i + 1}º valor dos vetores A e B = {c[i]}");
             }
        }
    }
}
