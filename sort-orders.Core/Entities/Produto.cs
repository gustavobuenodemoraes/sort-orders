﻿namespace sort_orders.Core.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome , double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
