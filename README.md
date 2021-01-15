# Teste de ordenação de pedidos
Teste para Foursys

## Contexto

Imagine-se trabalhando em uma loja virtual qualquer. Existe uma classe CarrinhoDeCompras que recebe e armazena um número indefinido de produtos selecionadas:
```c#
public class CarrinhoDeCompras
{
  ...
  
  public void Adiciona(Produto produto)
  {
    ...
  }
}
```
Um Produto é composto por nome e preço em decimal como no código abaixo:
```c#
carrinho.Adiciona(new Produto("Geladeira", 450.0));
```
Essa mesma loja virtual precisa encontrar, dentro do seu carrinho de compras, os produtos de maior e menor valor. Um possível algoritmo para esse problema seria percorrer a lista de produtos no carrinho, comparar um a um, e guardar sempre a referência para o menor e o maior produto encontrado até então.

## Desafio

Implemente esse algoritmo que encontrar, dentro do carrinho de compras, os produtos de maior e menor valor, utilizando as classes acima referidas (CarrinhoDeCompras e Produto) e criando uma classe MaiorEMenor que seja capaz de retornar os nomes dos produtos conforme exemplo abaixo:

```c#
CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
carrinho.Adiciona(new Produto("Liquidificador", 250.0));
carrinho.Adiciona(new Produto("Geladeira", 450.0));
carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

MaiorEMenor algoritmo = new MaiorEMenor();
algoritmo.Encontra(carrinho);

Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
```

A classe MaiorEMenor deve ser capaz de retorna os nomes corretamente para os seguintes cenários:

* Um único produto no carrinho
* Vários produtos no carrinho não ordenados
* Vários produtos no carrinho ordenados em ordem crescente
* Vários produtos no carrinho ordenados em ordem decrescente

## Desejável

- [ ] Criar os testes unitários para validar os 4 cenários
- [ ] Receber a lista através do prompt de comando
- [ ] Utilizar os princípios do SOLID aplicáveis 

## Instruções gerais
* Antes de iniciar o desenvolvimento informe via e-mail quando irá entregar a solução;
* Faça um fork desse repositório e efetue um pull request para entrega;
* Crie um setup.md informando todos os passos para configuração, execução e validação da aplicação.
