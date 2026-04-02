using Livraria.Domain.Entity;
using Livraria.Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Data
{
    public  class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options) { }
        public LivrariaContext()
        {
        }

        public DbSet<Livro> Livro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LivroMapping());
        }
    }
}
