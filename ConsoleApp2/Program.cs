using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos ao nosso restaurante.");
            Console.WriteLine("Mesa para quantas pessoas? (1 a 4).");

            int quantidadePessaos = int.Parse(Console.ReadLine());
            int[] pedidoPessoas = new int[quantidadePessaos];
            double[] valoresPedidos = new double[quantidadePessaos];
            double valorMesa = 0;
            double valorPrato = 0;
            double valorTotal;

            if (quantidadePessaos == 1)
            {
                valorMesa = 80;
            }
            else if (quantidadePessaos == 2)
            {
                valorMesa = 120;
            }
            else if (quantidadePessaos == 3)
            {
                valorMesa = 160;
            }
            else
            {
                valorMesa = 200;
            }

            char respostaEntrada;
            double valorEntrada = 0;
            do
            {
                Console.WriteLine("Podemos servir a entrada?");
                Console.WriteLine("(S) para sim ou (N) para não");
                respostaEntrada = char.Parse(Console.ReadLine());
                if (respostaEntrada == 'S' || respostaEntrada == 's')
                {
                    valorEntrada = 95;
                }
                else
                {
                    Console.WriteLine("Assim que quiser pedir a entrada pressione o número 1.");
                }

            } while (respostaEntrada == 'N' || respostaEntrada == 'n');

            char respostaPrato;
            do
            {
                Console.WriteLine("Podemos servir o prato princial?");
                Console.WriteLine("S para sim ou N para não");
                respostaPrato = char.Parse(Console.ReadLine());
                
                if (respostaPrato == 's' || respostaPrato == 'S')
                {
                    for (int i = 0; i < quantidadePessaos; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("Temos duas exelentes opções: (1 ou 2)");
                            Console.WriteLine("(1) Filé ao Wellington");
                            Console.WriteLine("(2) Macarronada ao molho pesto com camarão");
                        }

                        Console.WriteLine("Prato pessoa " + (i + 1) + " ?");
                        int numeroPedido = int.Parse(Console.ReadLine());
                        pedidoPessoas[i] = numeroPedido;

                        if (numeroPedido == 1)
                        {
                            valorPrato = valorPrato + 78;
                            valoresPedidos[i] = 78;
                        }
                        else
                        {
                            valorPrato = valorPrato + 88;
                            valoresPedidos[i] = 88;
                        }

                    }
                }
                else if (respostaPrato == 'n' || respostaPrato == 'N')
                {
                    Console.WriteLine("Assim que quiser pedir pressione S");
                }

            }
            while (respostaPrato == 'n' || respostaPrato == 'N');

            valorTotal = valorMesa + valorEntrada + valorPrato;

            Console.WriteLine("Valor da mesa reservada: R$" + valorMesa.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor da Entrada: R$" + valorEntrada.ToString("F2", CultureInfo.InvariantCulture));
            foreach (var item in valoresPedidos)
            {
                Console.WriteLine("Valor " + item);
            }
            Console.WriteLine("Valor do pedido: R$" + valorPrato.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Total " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Muito obrigado.");
        }
    }
}
