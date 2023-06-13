using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings;

internal class PaisMapping : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
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

        builder.Property(p => p.Senha)
               .HasColumnName("Senha")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasColumnType("varchar")
               .IsRequired();

        builder.Property(p => p.Telefone)
               .HasColumnName("Telefone")
               .HasColumnType("varchar")
               .IsRequired();

        builder.ToTable("Pais", "dbo");
    }
}
