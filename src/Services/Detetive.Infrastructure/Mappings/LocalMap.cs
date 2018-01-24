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

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(300);
        }
    }
}
