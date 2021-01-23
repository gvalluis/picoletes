using Picoletes.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Picoletes.Core.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto> GetProdutosByIdAsync(int id);
        Task<IReadOnlyList<Produto>> GetProdutosAsync();
    }
}
