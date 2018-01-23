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

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
