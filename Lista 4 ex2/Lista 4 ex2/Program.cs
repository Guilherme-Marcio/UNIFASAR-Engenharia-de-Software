using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double renda, somarendaF, media, contM, contF, quant3500;
            int idade, i;
            string sexo;
            
            i = 1; somarendaF = 0; contM = 0; contF = 0; quant3500 = 0;
            while (i <= 200)
            {
                Console.WriteLine($"Coleta de dados da pessoa {i}");

                Console.WriteLine("Qual o seu sexo? Digite 'M' para MASCULINO e 'F' para FEMININO");
                sexo = Console.ReadLine().ToUpper();
                Console.Clear();

                Console.WriteLine("Qual sua idade?");
                idade = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite o valor de sua renda em R$");
                renda = double.Parse(Console.ReadLine());
                Console.Clear();

            
                if (sexo == "M")
                {
                    contM = contM + 1;
                }
                else if (sexo == "F")
                {
                    contF = contF + 1;
                    somarendaF = somarendaF + renda;
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }

                if (renda >= 3500 && idade >= 23 && idade <= 30)
                {
                    quant3500 = quant3500 + 1;
                }

                i++;
            }

            media = somarendaF / contF;

            Console.WriteLine($"A quantidade de homens = {contM} e a quantidade de mulheres = {contF}");
            Console.WriteLine($"A média salarial das mulheres é = R${media}");
            Console.WriteLine($"A quantidade de pessoas que ganham mais de R$3500,00 e tem idade entre 23 e 30 anos = {quant3500}");

        }
    }
}
