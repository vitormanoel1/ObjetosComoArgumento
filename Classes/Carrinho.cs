using System;
using System.Collections.Generic;
namespace POO_ObjetosComoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        public void AdicionarProduto(Produto _produto) 
        {
            carrinho.Add(_produto);
        }
        public void MostrarProduto() 
        {
            if(carrinho != null) 
            {
                foreach(var item in carrinho) 
                {
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                }
            } 
            else 
            {
                Console.WriteLine("Não há nenhum produto no carrinho!");
            }
        }
        public void RemoverProduto(Produto _produto) 
        {
            carrinho.Remove(_produto);
        }
        public void MostrarValorTotal() 
        {
            ValorTotal = 0;
            if(carrinho != null) 
            {
                foreach (var item in carrinho) 
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O total do carrinho é: {ValorTotal}");
            } 
            else 
            {
                Console.WriteLine("O carrinho está vazio, tente novamente!");
            }
        }
        public void AlterarItem(int _codigo_procurado, Produto _novoProduto) 
        {
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Nome = _novoProduto.Nome;
            carrinho.Find(produto => produto.Codigo == _codigo_procurado).Preco = _novoProduto.Preco;
        }
    }
}