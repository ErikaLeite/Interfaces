using System;
using System.Collections.Generic;

namespace Interfaces.classes
{
    public class Carrinho : ICarrinho //A CLASSE ATUAL HERDA AS REGRAS DE NEGÓCIO VINDAS DA INTERFACE
    {

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _cod, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _cod) .Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _cod) .Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

         public void Exluir(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"Código do Produto: {item.Codigo} \nNome {item.Nome} \nValor R$ {item.Preco}\n");
            }
        }

        
    }
}