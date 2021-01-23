using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picoletes.API.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<IReadOnlyList<Produto>> GetProdutosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetProdutosByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
