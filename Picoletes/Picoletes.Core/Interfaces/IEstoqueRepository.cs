using Picoletes.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Picoletes.Core.Interfaces
{
    public interface IEstoqueRepository
    {
        Task<IReadOnlyList<Estoque>> GetEstoqueAsync();
        Task<Estoque> GetEstoqueByIdAsync(int id);
        Task PutRealizarRetirada(PedidoRetirada pedidoRetirada);
    }
}
