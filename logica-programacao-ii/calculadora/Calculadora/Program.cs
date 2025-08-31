using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Calculadora");
            Console.WriteLine("----------");
            Console.WriteLine("Digite [1] para somar dois números");
            Console.WriteLine("Digite [2] para subtrair dois números");
            Console.WriteLine("----------");

            var opcao = int.Parse(Console.ReadLine());

            if (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("Opção inválida, finalizando o programa.");
            } else if (opcao == 1 || opcao == 2)
            {
                Console.WriteLine("Digite o primeiro número:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                n2 = int.Parse(Console.ReadLine());
            }
            if (opcao == 1)
            {
                int resultado = Soma(n1, n2); // entender pq tá dando erro aqui
                Console.WriteLine($"O resultado da soma é {resultado}.");
            }
            else if (opcao == 2)
            {
                int resultado = Subtracao(n1, n2);
                Console.WriteLine($"O resultado da subtração é {resultado}.");
            }
        }


        static int Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
    }
}

