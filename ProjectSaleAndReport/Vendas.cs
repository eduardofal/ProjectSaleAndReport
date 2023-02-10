using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectSaleAndReport
{
    internal class Vendas
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Vendas(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            double total = Preco * Quantidade

        ;   return total;
        }

        public override string ToString()
        {
            string dados = "Nome: " + Nome + " | Preço: " + Preco + " | Quantidade: " + Quantidade + "| Valor total: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

            return dados;
        }
    }
}
