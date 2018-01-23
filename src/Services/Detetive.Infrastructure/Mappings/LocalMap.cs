using Detetive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Detetive.Infrastructure.Mappings
{
    public class LocalMap : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.ToTable("Locais", DetetiveContext.DEFAULT_SCHEMA);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
