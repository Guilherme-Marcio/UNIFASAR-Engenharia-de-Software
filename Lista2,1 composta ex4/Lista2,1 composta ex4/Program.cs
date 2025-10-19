using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_1_composta_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Digite uma letra do alfabeto");
            letra = char.ToUpper(char.Parse(Console.ReadLine()));


            if (letra == 'A' | letra == 'E' | letra == 'I' | letra == 'O' | letra == 'U')
            {
                Console.WriteLine("A letra é uma vogal");
            }
            else
            {
                Console.WriteLine("A letra é uma consoante");
            }
        }
    }
}
