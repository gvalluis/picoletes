namespace Picoletes.Core.Models
{
    public class UnidadeRetirada
    {
        public UnidadeRetirada(string id, string descricaoProduto, int qtdEstoque, int qtdRetirada, int validadeForaFreezer)
        {
            Id = id;
            DescricaoProduto = descricaoProduto;
            QtdEstoque = qtdEstoque;
            QtdRetirada = qtdRetirada;
            ValidadeForaFreezer = validadeForaFreezer;
        }

        public string Id { get; set; }
        public string DescricaoProduto { get; set; }
        public int QtdEstoque { get; set; }
        public int QtdRetirada { get; set; }
        public int ValidadeForaFreezer { get; set; }
    }
}
