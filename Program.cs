using System;
using Interfaces.classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Carrinho de Compras\n");
            Console.ResetColor();

            Carrinho carrinho = new Carrinho();

            //LISTA DE PRODUTOS DISPONÍVEIS PARA INSERIR "COMPRA"
            Produto item1 = new Produto();
            item1.Codigo  = 1001;
            item1.Nome    = "Caneta Bic [Azul]";
            item1.Preco   = 1.99f;

            Produto item2 = new Produto();
            item2.Codigo  = 1002;
            item2.Nome    = "Lapiseira Faber Castell 0.5mm [Princesas Disney]";
            item2.Preco   = 10.99f;

            Produto item3 = new Produto();
            item3.Codigo  = 1003;
            item3.Nome    = "Caderno Ben10 [10 Matérias]";
            item3.Preco   = 34.99f;

            Produto item4 = new Produto();
            item4.Codigo  = 1004;
            item4.Nome    = "Papel Sulfite pacote 500folhas [Senninha]";
            item4.Preco   = 21.99f;

            //INSERÇÃO DE PRODUTOS AO CARRINHO
            carrinho.Cadastrar(item1);
            carrinho.Cadastrar(item2);
            carrinho.Cadastrar(item4);

            //EXIBIÇÃO DE PRODUTOS
            carrinho.Listar();

            //HOUVE ALTERAÇÃO NA LISTA DE PRODUTOS
            Console.ForegroundColor = ConsoleColor.Green;
            
            //NESTE CASO, O "CLIENTE" SUBSITTUIU O ITEM 4 PELO ITEM 3
            carrinho.Alterar(item4.Codigo, item3);
            carrinho.Listar();

            Console.ResetColor();

        }
    }
}
