using Microsoft.EntityFrameworkCore;
using TesteTecnico.Domain.Entites;

namespace TesteTecnico.Infra.Core.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
