using System;
using POO_ObjetosComoArgumento.Classes;

namespace POO_ObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Boné", 49.99f);
            Produto p2 = new Produto(2, "Bermuda", 99.99f);
            Produto p3 = new Produto(3, "Camiseta", 499.99f);
            Produto p4 = new Produto(4, "Meia", 129.99f);
            Produto p5 = new Produto(5, "Chuteira", 499.99f);

            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);
            cart.AdicionarProduto(p5);

            cart.MostrarProduto();
        }
    }
}
