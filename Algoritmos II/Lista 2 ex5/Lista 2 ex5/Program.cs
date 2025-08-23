using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, T;

            Console.WriteLine("Digite uma palavra para o armazenamento A:");
            A = Console.ReadLine();
            Console.WriteLine("Digite outra palavra para o armazenamento B:");
            B = Console.ReadLine();

            Console.WriteLine("O valor de A e B são respectivamente:" + A + " e " + B);
            Console.WriteLine("Agora os valores vão ser trocados... Aperte ENTER");
            Console.ReadLine();

            T = A;
            A = B;
            B = T;

            Console.WriteLine("Agora o valor de A = " + A);  
            Console.WriteLine("Agora o valor de B = " + B);
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadLine();
             
        }
    }
}
