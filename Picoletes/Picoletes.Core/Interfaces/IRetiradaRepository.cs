using Picoletes.Core.Models;

namespace Picoletes.Core.Interfaces
{
    public interface IRetiradaRepository
    {
        public void RealizarRetirada();
        public void GerarBaseRetirada();
        public void RealizarRetirada(PedidoRetirada pedido);
    }
}
