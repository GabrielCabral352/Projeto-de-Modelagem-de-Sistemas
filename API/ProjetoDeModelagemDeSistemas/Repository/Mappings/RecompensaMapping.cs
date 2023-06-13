using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class RecompensaMapping : IEntityTypeConfiguration<Recompensa>
{
    public void Configure(EntityTypeBuilder<Recompensa> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.NomeRecompensa)
               .HasColumnName("NomeRecompensa")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.RecompensaPontos)
               .HasColumnName("RecompensaPontos")
               .HasColumnType("int")
               .IsRequired();

        builder.ToTable("Recompensa", "dbo");
    }
}
