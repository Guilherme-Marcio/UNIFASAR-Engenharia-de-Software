using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, soma, media;
            int i;

            i = 1;
            soma = 0;

            while (i <= 40)
            {
                Console.WriteLine($"Digite a nota {i}:");
                nota = double.Parse(Console.ReadLine());
                soma = soma + nota;
                i++; //Atualização
            }

            media = soma / 40;


            Console.Clear();
            Console.WriteLine($"A média é = {media}");
        }
    }
}
