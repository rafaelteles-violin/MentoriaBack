using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Livraria.Domain.Entity;

namespace Livraria.Infra.Mapping
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
              .HasColumnName("Nome");

            builder.Property(x => x.AnoLancamento)
              .HasColumnName("AnoLancamento");

            builder.Property(x => x.Autor)
                .HasColumnName("Autor");
        }
    }
}
