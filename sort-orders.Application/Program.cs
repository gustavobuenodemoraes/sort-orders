using sort_orders.Core;
using sort_orders.Core.Entities;
using System;

namespace sort_orders.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            MaiorEMenor algoritmo = null;
            var opcao = -1;
            while (opcao != 0)
            {
                Menu();
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Produto(carrinho);
                        break;
                    case 2:
                        algoritmo = Ordenar(carrinho);
                        break;
                    case 3:
                        Mosrtar(algoritmo);
                        break;
                }
            }

        }

        private static void Mosrtar(MaiorEMenor algoritmo)
        {
            if (algoritmo == null)
            {
                Console.WriteLine("Carrinho Vazio");

            }
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
            Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        }

        private static MaiorEMenor Ordenar(CarrinhoDeCompras carrinho)
        {
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);
            return algoritmo;
        }

        private static void Produto(CarrinhoDeCompras carrinho)
        {
            
            Console.WriteLine("=================Produto=================");
            Console.WriteLine("=========================================");
            Console.WriteLine("");

            Console.WriteLine("Produto:");
            string Produto = Console.ReadLine();
            Console.WriteLine("Valor:");
            var Valor = Convert.ToDouble(Console.ReadLine());


            carrinho.Adiciona(new Produto(Produto, Valor));
        }

        private static void Menu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=================Carinho=================");
            Console.WriteLine("=========================================");
            Console.WriteLine("");

            Console.WriteLine("1 - Inserir Produto");
            Console.WriteLine("2 - Mostrar Menor e Maior Porduto");
            Console.WriteLine("3 - Mostrar Todos os Produtos");
            Console.WriteLine("0 - Sair");

        }
    }
}
