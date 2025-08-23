using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2_1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2 , max, min;
            
            
            
            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os valores são iguais");
            }
            double num1m;

            if (num1 > num2)
            {
               num1m = num1 - num2;
                Console.WriteLine(" O numero " +num1+ " é maior que o numero "+num2+ " e a diferença dos valores é: " + num1m);
            }
            double num2m;
            if (num2 > num1) { 
                num2m = num2 - num1;
                Console.WriteLine(" O numero " + num2 + " é maior que o numero " + num1 + " e a diferença dos valores é: " + num2m);
            }
            



        }

    }
}
