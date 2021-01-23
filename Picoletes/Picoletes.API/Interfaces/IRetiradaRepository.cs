using Picoletes.API.Models;

namespace Picoletes.API.Interfaces
{
    public interface IRetiradaRepository
    {
        public void RealizarRetirada();
        public void GerarBaseRetirada();

        public void RealizarRetirada(PedidoRetirada pedido);
    }
}
