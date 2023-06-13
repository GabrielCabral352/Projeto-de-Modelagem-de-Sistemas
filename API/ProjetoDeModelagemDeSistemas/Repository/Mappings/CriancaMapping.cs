using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class CriancaMapping : IEntityTypeConfiguration<Crianca>
{
    public void Configure(EntityTypeBuilder<Crianca> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.NomeCompleto)
               .HasColumnName("NomeCompleto")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.Cpf)
               .HasColumnName("Cpf")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.UserName)
               .HasColumnName("UserName")
               .HasColumnType("varchar")
               .IsRequired();

        builder.HasOne(m => m.IdPais)
              .WithMany()
              .HasForeignKey("PaisId")
              .IsRequired();

        builder.Property(p => p.DataNascimento)
               .HasColumnName("DataNascimento")
               .HasColumnType("datetime2")
               .IsRequired();

        builder.Property(p => p.Pontuacao)
               .HasColumnName("Pontuacao")
               .HasColumnType("int")
               .IsRequired();

        builder.ToTable("Crianca", "dbo");
    }
}
