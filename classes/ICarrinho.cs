namespace Interfaces.classes
{
    public interface ICarrinho
    {
         // C R U D

         //CREATE
         void Cadastrar(Produto produto);

         //READ
         void Listar();

         //UPDATE
         void Alterar(int _cod, Produto produto);

         //DELETE
         void Exluir(Produto produto);

        //OBSERVAÇÕES IMPORTANTES:
        
        //NÃO É POSSIVEL CRIAR UMA INSTÂNCIA DE INTERFACE
        //A INTERFACE SERVE COMO REGRA DE NEGÓCIO, PODENDO SER OU NÃO APLICADA DE ACORDO COM A CIRCUNSTÂNCIA
    }
}