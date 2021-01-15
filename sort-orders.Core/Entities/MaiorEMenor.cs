using sort_orders.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace sort_orders.Core
{
    public class MaiorEMenor
    {

        public Produto Menor { get; set; }
        public Produto Maior { get; set; }
       
        public void Encontra(CarrinhoDeCompras carrinho)
        {
            Menor = carrinho.produtos.FirstOrDefault();
            Maior = carrinho.produtos.FirstOrDefault();

            foreach (var produto in carrinho.produtos)
            {
                if (produto.Valor > Maior.Valor)
                {
                    Maior = produto;
                }

                if (produto.Valor < Menor.Valor)
                {
                    Menor = produto;
                }
            }
        }

    }
}
