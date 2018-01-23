using Detetive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Detetive.Infrastructure.Mappings
{
    public class ArmaMap : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("Armas", DetetiveContext.DEFAULT_SCHEMA);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(300);
        }
        //http://www.entityframeworktutorial.net/code-first/move-configurations-to-seperate-class-in-code-first.aspx
        //http://netcoders.com.br/mapeamento-com-entity-framework-code-first-fluent-api-parte-2/
    }
}