using sort_orders.Core.Entities;
using sort_orders.Core.Interface;
using System.Collections.Generic;
using System.Linq;

namespace sort_orders.Core
{
    public class CarrinhoDeCompras : ICarrinhoDeCompras
    {
        public readonly List<Produto> produtos;

        public CarrinhoDeCompras()
        {
            produtos = new List<Produto>();
        }

        public List<Produto> Adiciona(Produto produto)
        {
            produtos.Add(produto);
            return produtos;
        }

        public List<Produto> Adiciona(List<Produto> produtos)
        {
            produtos.AddRange(produtos);
            return produtos;
        }
    }
}
