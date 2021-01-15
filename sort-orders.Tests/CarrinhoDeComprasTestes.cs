using sort_orders.Core;
using sort_orders.Core.Entities;
using Xunit;

namespace sort_orders.Tests
{
    public class CarrinhoDeComprasTestes
    {
        [Fact]
        public void VerificarMaiorEMenor()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.NotNull(carrinho);
            Assert.NotNull(algoritmo.Menor);
            Assert.NotNull(algoritmo.Maior);
            Assert.Equal(3, carrinho.produtos.Count);
            Assert.Equal(70, algoritmo.Menor.Valor);
            Assert.Equal(450, algoritmo.Maior.Valor);
        }

        [Fact]
        public void OrdernarPorMenorPreco()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            var carrinhoOrdenado = new Ordenar();
            carrinho = carrinhoOrdenado.OrderPorMenorPreco(carrinho);

            Assert.NotNull(carrinho);
            Assert.Equal(3, carrinho.produtos.Count);
            Assert.Equal(70, carrinho.produtos[0].Valor);
            Assert.Equal(250, carrinho.produtos[1].Valor);
            Assert.Equal(450, carrinho.produtos[2].Valor);
        }

        [Fact]
        public void OrdernarPorMaiorrPreco()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            var carrinhoOrdenado = new Ordenar();
            carrinho = carrinhoOrdenado.OrderPorMaiorPreco(carrinho);

            Assert.NotNull(carrinho);
            Assert.Equal(3, carrinho.produtos.Count);
            Assert.Equal(450, carrinho.produtos[0].Valor);
            Assert.Equal(250, carrinho.produtos[1].Valor);
            Assert.Equal(70, carrinho.produtos[2].Valor);
        }

        [Fact]
        public void CarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.NotNull(carrinho);
            Assert.Null(algoritmo.Menor);
            Assert.Null(algoritmo.Maior);
            Assert.Empty(carrinho.produtos);
        }
    }
}
