using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cat1, cat2, hip;

            Console.WriteLine("Digite o valor do cateto adjascente:");
            cat1 =double.Parse (Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto oposto:");
            cat2 =double.Parse (Console.ReadLine());
            
            hip = Math.Sqrt(Math.Pow(cat1, 2)+ Math.Pow(cat2, 2));
            Console.WriteLine("O valor da hipotenusa = " + hip);

            Console.WriteLine("Aperte qualquer tecla para fechar...");
            Console.ReadLine();



        }
    }
}
