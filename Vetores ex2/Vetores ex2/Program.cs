using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_ex2
{
    internal class Program
    {
        static double[] RetornaResult (double[] a)
        {
            double[] b = new double[3];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i] * a[i];

            }

            return b;
        }
        static void Main(string[] args)
        {
            double[] a = new double[3];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número.");
                a[i] = double.Parse(Console.ReadLine());
            }

            double[] b = RetornaResult(a);

            /*
             Console.WriteLine($"{String.Join("/ ", c)}"); 
            */

            for (int i = 0;i < b.Length; i++)
            {
                Console.WriteLine($"O quadrado do {i + 1}º número = {b[i]} ");
            }
        }
    }
}
