using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2._1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diasemana;
            Console.WriteLine("Digite um dia da semana:");
            diasemana = Console.ReadLine();

            if (diasemana == "Sábado"){
                Console.WriteLine("Fim de semana");
            }
            if (diasemana == "Domingo")
            {
                Console.WriteLine("Fim de semana");
            }
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadLine();
           

        }
    }
}
