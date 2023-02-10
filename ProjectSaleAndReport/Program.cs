using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectSaleAndReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("DIGITE 0 PARA ENCERRAR O PROGRAMA");
            Console.WriteLine("DIGITE 1 PARA PUXAR RELATÓRIO");
            Console.WriteLine("DIGITE 2 PARA REALIZAR UMA VENDA");
            Console.Write("Escolha uma opção: ");
            int opc = int.Parse(Console.ReadLine());

            List<Vendas> list = new List<Vendas>();

            while (opc != 0)
            {
                Console.WriteLine();
                if (opc == 2)
                {
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade do produto: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    list.Add(new Vendas(nome, preco, quantidade));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Histórico de vendas:");
                    foreach (Vendas obj in list)
                    {                    
                        Console.WriteLine(obj);
                    }
                }


                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("DIGITE 1 PARA PUXAR RELATÓRIO");
                Console.WriteLine("DIGITE 2 PARA REALIZAR UMA VENDA");
                Console.Write("Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());

            }
        }
    }
}