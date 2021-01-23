using Microsoft.EntityFrameworkCore;
using Picoletes.API.Data;
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
        private readonly PicoletesContext _context;
        public ProdutoRepository(PicoletesContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Produto>> GetProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutosByIdAsync(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }
    }
}
