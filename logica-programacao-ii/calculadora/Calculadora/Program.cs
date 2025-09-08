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
            // Menu de declaração de variáveis
            // Perguntar se tem como declarar n1 e n2 como locais
            int n1 = 0;
            int n2 = 0;
            int opcao = 0;
            int operacao = 0;

            while (opcao < 5)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("----------");
                Console.WriteLine("Digite [1] para realizar adições");
                Console.WriteLine("Digite [2] para realizar subtrações");
                Console.WriteLine("Digite [3] para realizar multiplicações");
                Console.WriteLine("Digite [4] para realizar divisões");
                Console.WriteLine("Digite [5] para sair");
                Console.WriteLine("----------");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Menu pra perguntar se o usuário quer somar apenas dois números ou mais 
                if (opcao < 1 || opcao < 4)
                {
                    Console.WriteLine("Digite [1] para operações com dois números");
                    Console.WriteLine("Digite [2] para operações com mais de dois números");
                    operacao = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

                if (opcao == 4)
                {
                    operacao = 1;
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Saindo do programa.");
                }
                else if (opcao > 5)
                {
                    Console.WriteLine("Opção inválida, encerrando.");
                }

                if (operacao != 1 && operacao != 2 && opcao < 5)
                {
                    Console.WriteLine("Opção inválida, encerrando.");
                    break;
                }

                // Estrutura para o caso de soma com dois números
                if (operacao == 1)
                {
                    if (opcao < 5)
                    {
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                    }

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("O resultado da adição é: " + Soma(n1, n2));
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("O resultado da subtração é: " + Subtracao(n1, n2));
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("O resultado da multiplicação é: " + Multiplicacao(n1, n2));
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.WriteLine("O resultado da divisão é: " + Divisao(n1, n2));
                            Console.WriteLine("");
                            break;
                    }
                }
                // Estrutura para o caso de soma com mais de dois números
                if (operacao == 2 && opcao < 4) {
                    Console.WriteLine("Quantos números você quer digitar? ");
                    int quantidade = int.Parse(Console.ReadLine());

                    int[] vetor = new int[quantidade];

                    for (int i = 0; i < quantidade; i++)
                    {
                        Console.WriteLine($"Digite o { i + 1}º número: ");
                        vetor[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                    }

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("O resultado da adição é: " + SomaVarios(vetor));
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("O resultado da subtração é: " + SubtracaoVarios(vetor));
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("O resultado da multiplicação é: " + MultiplicacaoVarios(vetor));
                            Console.WriteLine("");
                            break;
                    }
                }




            }


        }

        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        static int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }

        static int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }

        static int SomaVarios(int[] vetor)
        {
            int resultado = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                resultado += vetor[i];
            }
            return resultado;
        }

        static int SubtracaoVarios(int[] vetor)
        {
            int resultado = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                resultado -= vetor[i];
            }
            return resultado;
        }

        static int MultiplicacaoVarios(int[] vetor)
        {
            int resultado = 1;
            for (int i = 0; i < vetor.Length; i++)
            {
                resultado *= vetor[i];
            }
            return resultado;
        }
    }
}

   

