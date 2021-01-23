using Picoletes.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Picoletes.Core.Interfaces
{
    public interface IRetiradaRepository
    {
        Task<IReadOnlyList<Estoque>> GetEstoqueAsync();
        Task<Estoque> GetEstoqueByIdAsync(int id);
        public void RealizarRetirada();
        public void GerarBaseRetirada();
        public void RealizarRetirada(PedidoRetirada pedido);
    }
}
