using sort_orders.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sort_orders.Core
{
    public class Ordenar
    {
        public CarrinhoDeCompras OrderPorMenorPreco(CarrinhoDeCompras carrinho)
        {
            var produtos = carrinho.produtos.OrderBy(x => x.Valor).ToList();

            carrinho.produtos.Clear();
            carrinho.produtos.AddRange(produtos);

            return carrinho;
        }

        public CarrinhoDeCompras OrderPorMaiorPreco(CarrinhoDeCompras carrinho)
        {
            var produtos = carrinho.produtos.OrderByDescending(x => x.Valor).ToList();

            carrinho.produtos.Clear();
            carrinho.produtos.AddRange(produtos);

            return carrinho;
        }
    }
}
