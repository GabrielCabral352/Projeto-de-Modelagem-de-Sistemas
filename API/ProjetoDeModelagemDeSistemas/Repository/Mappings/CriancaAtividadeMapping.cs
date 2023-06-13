using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class CriancaAtividadeMapping : IEntityTypeConfiguration<CriancaAtividade>
{
    public void Configure(EntityTypeBuilder<CriancaAtividade> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(m => m.IdCrianca)
             .WithMany()
             .HasForeignKey("CriancaId")
             .IsRequired();

        builder.HasOne(m => m.IdAtividade)
             .WithMany()
             .HasForeignKey("AtividadeId")
             .IsRequired();

        builder.Property(p => p.Realizado)
               .HasColumnName("Descricao")
               .HasColumnType("bit")
               .IsRequired();

        builder.ToTable("CriancaAtividade", "dbo");
    }
}
