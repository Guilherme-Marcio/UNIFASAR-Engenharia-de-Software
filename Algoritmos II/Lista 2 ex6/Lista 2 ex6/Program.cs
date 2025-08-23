using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salariomin, salariop, calc;

            Console.WriteLine("Digite o valor do salário mínimo atual:");
            salariomin = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salário:");
            salariop = double.Parse(Console.ReadLine());

            calc = salariop / salariomin;
            
            
            Console.WriteLine("Você recebe " + (int)calc + " salários mínimos");
            Console.WriteLine("Aperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
