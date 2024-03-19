using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
             double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
             double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operação: +, -, *, /");
             string operacao = Console.ReadLine();  

            switch (operacao)
            {
                case "+":
                    double resultado = n1 + n2;
                    Console.WriteLine("O resultado da operacão é: " + resultado);
                break;

                case "-":
                    double resultado2 = n1 - n2;
                    Console.WriteLine("O resultado da operacão é: " + resultado2);
                break;

                case "*":
                    double resultado3 = n1 * n2;
                    Console.WriteLine("O resultado da operacão é: " + resultado3);
                break;

                case "/":
                    double resultado4 = n1 + n2;
                    Console.WriteLine("O resultado da operacão é: " + resultado4);
                break;
            }
        }
    }
}
