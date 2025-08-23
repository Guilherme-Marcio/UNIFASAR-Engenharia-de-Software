using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_Algoritmos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, media;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média é: " + media);






        }
    }
}
