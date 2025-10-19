using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_1_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anonascimento, idade;

            Console.WriteLine("Digite o seu ano de nascimento:");
            anonascimento = int.Parse(Console.ReadLine());
            idade = 2025 - anonascimento;

            if (idade >= 18 | idade <= 65){

                Console.WriteLine("Sua idade é " + idade + " e você esta dentro do intervalo.");
            }

            if (idade < 18 | idade > 65){

                Console.WriteLine("Sua idade é " + idade + " e você esta fora do intervalo");
            }
            Console.WriteLine("Aperte qualquer tecla para sair ...");
            Console.ReadLine();
        }   
    }
}
