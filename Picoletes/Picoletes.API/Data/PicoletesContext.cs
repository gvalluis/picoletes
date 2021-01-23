using Microsoft.EntityFrameworkCore;
using Picoletes.Core.Models;

namespace Picoletes.API.Data
{
    public class PicoletesContext : DbContext
    {
        public PicoletesContext(DbContextOptions<PicoletesContext> options) : base(options)
        {
        }

        public DbSet<PedidoRetirada> PedidoRetirada { get; set; }
        public DbSet<Produto> Produtos   { get; set; }
        public DbSet<Estoque> Estoque   { get; set; }
    }
}
