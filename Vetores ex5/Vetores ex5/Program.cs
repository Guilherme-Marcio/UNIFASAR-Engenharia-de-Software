using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_ex5
{
    internal class Program
    {
        static double[] SomaouMult(double[] a)
        {
            double[] b = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {

                if (i % 2 == 0)
                {
                    b[i] = a[i] * 5;
                }
                else
                {
                    b[i] = a[i] + 5;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            double[] a = new double[10];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número:");
                a[i] = double.Parse(Console.ReadLine());
            }
            
            Console.Clear();
            string vetora = String.Join("/", a);
            string vetorb = String.Join("/", SomaouMult(a));
            Console.WriteLine($"O conteúdo do vetor A é {vetora}");
            Console.WriteLine($"O conteúdo do vetor B é {vetorb}");
        }
    }
}
