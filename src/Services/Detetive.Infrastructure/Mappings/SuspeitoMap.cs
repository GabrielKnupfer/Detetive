using Detetive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Detetive.Infrastructure.Mappings
{
    public class SuspeitoMap : IEntityTypeConfiguration<Suspeito>
    {
        public void Configure(EntityTypeBuilder<Suspeito> builder)
        {
            builder.ToTable("Suspeitos", DetetiveContext.DEFAULT_SCHEMA);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(300);
        }
    }
}
