using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class CriancaRecompensaMapping : IEntityTypeConfiguration<CriancaRecompensa>
{
    public void Configure(EntityTypeBuilder<CriancaRecompensa> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(m => m.IdCrianca)
             .WithMany()
             .HasForeignKey("CriancaId")
             .IsRequired();

        builder.HasOne(m => m.IdRecompensa)
             .WithMany()
             .HasForeignKey("RecompensaId")
             .IsRequired();

        builder.Property(p => p.DataResgate)
               .HasColumnName("DataResgate")
               .HasColumnType("datetime2")
               .IsRequired();

        builder.ToTable("CriancaRecompensa", "dbo");
    }
}
