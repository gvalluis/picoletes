namespace Picoletes.Dominio.Models
{
    public class Retirada
    {
        public string Id { get; set; }
        public string DescricaoProduto { get; set; }
        public int QtdEstoque { get; set; }
        public int QtdRetirada { get; set; }
        public int ValidadeForaFreezer { get; set; }
    }
}
