using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class AtividadeMapping : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.NomeAtividade)
               .HasColumnName("NomeAtividade")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.Pontos)
               .HasColumnName("Pontos")
               .HasColumnType("int")
               .IsRequired();

        builder.ToTable("Atividade", "dbo");
    }
}
