using HpViagensApiCsharpe.Model;
using Microsoft.EntityFrameworkCore;

namespace HpViagensApiCsharpe.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Viagem>? Viagens { get; set; }
        public DbSet<Pagamento>? Pagamentos { get; set; }
        public DbSet<Reserva>? Reservas { get; set; }
    }
}
