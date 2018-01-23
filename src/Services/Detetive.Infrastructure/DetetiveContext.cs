using Detetive.Domain.Entities;
using Detetive.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Detetive.Infrastructure
{
    public class DetetiveContext : DbContext
    {

        public const string DEFAULT_SCHEMA = "detetive";

        public DetetiveContext(DbContextOptions<DetetiveContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArmaMap());
            modelBuilder.ApplyConfiguration(new LocalMap());
            modelBuilder.ApplyConfiguration(new SuspeitoMap());
        }

        public DbSet<Arma> Armas { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Suspeito> Suspeitos { get; set; }
    }
}