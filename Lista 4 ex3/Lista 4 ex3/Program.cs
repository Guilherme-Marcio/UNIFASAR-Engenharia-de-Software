using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, somax, somay, media, a360;
            int i;

            i = 1; somax = 0; somay = 0; a360 = 0;

            while (i <= 50)
            {
                Console.WriteLine($"Digite a {i} dimensão de X em metros:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a {i} dimensão de Y em mentros");
                y = double.Parse(Console.ReadLine());
                Console.Clear();

                somax = somax + x;
                somay = somay + y;

                if (x >= 360)
                {
                    a360 = a360 + 1;
                }

                if (y >= 360)
                {
                    a360 = a360 + 1;
                }

            
                i++;

            }

            media = (somax + somay) / 50;

            Console.WriteLine($"A média das areas é {media}");
            Console.WriteLine($"A quantidade de terrenos com terrenos superiores a 360 m2 é {a360}");


        }
    }
}
