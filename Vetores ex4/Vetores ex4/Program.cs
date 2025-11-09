using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_ex4
{
    internal class Program
    {
        static double MediaTurma(double[] a)
        {
            int media = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 6)
                {
                    media++;
                }
            }
            return media;
        }
        static void Main(string[] args)
        {
            double[] a = new double[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Digite a {i + 1}º nota: ");
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Existem {MediaTurma(a)} notas acima da média.");


        }
    }
}
