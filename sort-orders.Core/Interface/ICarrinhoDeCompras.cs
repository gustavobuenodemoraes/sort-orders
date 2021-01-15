using sort_orders.Core.Entities;
using System.Collections.Generic;

namespace sort_orders.Core.Interface
{
    public interface ICarrinhoDeCompras
    {
        List<Produto> Adiciona(Produto produto);
    }
}
