using Microsoft.EntityFrameworkCore;
using Picoletes.API.Models;

namespace Picoletes.API.Data
{
    public class PicoletesContext : DbContext
    {
        public PicoletesContext(DbContextOptions<PicoletesContext> options) : base(options)
        {
        }

        public DbSet<PedidoRetirada> PedidoRetirada { get; set; }

    }
}
