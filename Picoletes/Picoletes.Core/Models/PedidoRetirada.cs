using System.Collections.Generic;

namespace Picoletes.Core.Models
{
    public class PedidoRetirada
    {
        public int Id { get; set; }
        public List<UnidadeRetirada> ProdutosRetirados { get; set; }
    }
}
