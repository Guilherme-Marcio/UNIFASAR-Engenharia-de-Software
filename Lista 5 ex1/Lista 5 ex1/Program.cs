using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_5_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,positivo, negativo, nulo;

            positivo = 0; negativo = 0; nulo = 0;
            for (int i = 1; i <= 5; i++) {

                Console.WriteLine($"Digte o {i} número:");
                numero = int.Parse( Console.ReadLine());

                if (numero > 0)
                {
                    positivo = positivo + 1;
                }

                else if (numero < 0)
                {

                    negativo = negativo + 1;
                }

                else {
                
                    nulo = nulo + 1;
                }
            
            }

            Console.WriteLine($"A quantidade de números postivios é {positivo}");
            Console.WriteLine($"A quantidade de números negativos é {negativo}");
            Console.WriteLine($"A quantidade de números nulos é {nulo}");
        }
    }
}
